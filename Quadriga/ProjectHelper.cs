using Firebase.Auth;
using Google.Api;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Quadriga
{
    public class ProjectHelper
    {
        public List<string> projectsID;
        public List<string> projectsName;
        public List<string> currentGroups;
        public List<string> currentGroupsID;

        public ProjectHelper()
        {
            projectsID = new List<string>();
            projectsName = new List<string>();
            currentGroups = new List<string>();
            currentGroupsID = new List<string>();
        }

        public async Task CreateProject(string projectName, string ownerEmail, FirestoreDb database)
        {
            Dictionary<string, object> projectData = new()
            {
                {"projectname", projectName},
                {"owneremail", ownerEmail }
            };
            await database.Collection("projects").AddAsync(projectData);
        }
        public async Task RenameProject(string projectName, string projectID, FirestoreDb database)
        {
            DocumentReference docRef = database.Collection("projects").Document(projectID);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"projectname", projectName }
            };
            await docRef.UpdateAsync(parameters);
        }

        public async Task AddGroupInProject(string projectID, string groupID, FirestoreDb database)
        {
            DocumentReference docRef = database.Collection("groups").Document(groupID);
            await docRef.UpdateAsync("projectid", FieldValue.ArrayUnion(projectID));
        }

        public async Task DeleteGroupInProject(string projectID, string groupID, FirestoreDb database)
        {
            DocumentReference docRef = database.Collection("groups").Document(groupID);
            await docRef.UpdateAsync("projectid", FieldValue.ArrayRemove(projectID));
        }
        public async Task DeleteProject(string projectID, FirestoreDb database)
        {
            DocumentReference docRef = database.Collection("projects").Document(projectID);
            await docRef.DeleteAsync();

            Query docQuery = database.Collection("groups");
            QuerySnapshot QuerySnapshot = await docQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot docSnapshot in QuerySnapshot.Documents)
            {
                DocumentReference docReference = database.Collection("groups").Document(docSnapshot.Id);
                await docReference.UpdateAsync("projectid", FieldValue.ArrayRemove(projectID));
            }

        }
        public async Task GetProjectIDList(Authentication authentication, FirestoreDb database)
        {
            projectsID.Clear();

            Query projectsQuery = database.Collection("projects");
            QuerySnapshot QuerySnapshot = await projectsQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot projectsSnapshot in QuerySnapshot.Documents)
            {
                DocumentReference projReference = database.Collection("projects").Document(projectsSnapshot.Id);
                DocumentSnapshot snapshot = await projReference.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> projValues = snapshot.ToDictionary();
                    projValues.TryGetValue("owneremail", out object ownerEmail);
                    if (Convert.ToString(ownerEmail) == authentication.firebaseAuthLink.User.Email)
                    {
                        projectsID.Add(projReference.Id);
                    }
                }
            }
        }
        public async Task GetProjectNames(FirestoreDb database)
        {
            projectsName.Clear();
            if (projectsID != null)
            {
                foreach (string ID in projectsID)
                {
                    DocumentReference projReference = database.Collection("projects").Document(ID);
                    DocumentSnapshot snapshot = await projReference.GetSnapshotAsync();
                    Dictionary<string, object> projValues = snapshot.ToDictionary();
                    projValues.TryGetValue("projectname", out object name);
                    projectsName.Add(Convert.ToString(name));
                }
            }
        }
        public async Task GetGroupInProject(string projectId, Authentication authentication)
        {
            currentGroups.Clear();
            currentGroupsID.Clear();
            Query projectsQuery = authentication.database.Collection("groups");
            QuerySnapshot QuerySnapshot = await projectsQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot projectsSnapshot in QuerySnapshot.Documents)
            {
                DocumentReference groupRef = authentication.database.Collection("groups").Document(projectsSnapshot.Id);
                DocumentSnapshot snapshot = await groupRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> groupValues = snapshot.ToDictionary();
                    groupValues.TryGetValue("projectid", out object projectid);
                    IEnumerable enumerable = projectid as IEnumerable;
                    if (enumerable != null)
                    {
                        foreach (object element in enumerable)
                        {
                            if (element.ToString() == projectId)
                            {
                                currentGroupsID.Add(groupRef.Id);
                            }
                        }
                    }
                }

            }
            Groups groups = new Groups(authentication.database);
            groups.groupsID = currentGroupsID;
            await groups.GetGroupsNames();
            currentGroups = groups.groupsNames;
        }
        public async Task GetGroupsOutProject(string projectId, Authentication authentication)
        {
            currentGroups.Clear();
            currentGroupsID.Clear();
            Query projectsQuery = authentication.database.Collection("groups");
            QuerySnapshot QuerySnapshot = await projectsQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot projectsSnapshot in QuerySnapshot.Documents)
            {
                DocumentReference groupRef = authentication.database.Collection("groups").Document(projectsSnapshot.Id);
                DocumentSnapshot snapshot = await groupRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> groupValues = snapshot.ToDictionary();
                    groupValues.TryGetValue("projectid", out object projectid);
                    IEnumerable enumerable = projectid as IEnumerable;
                    if (enumerable != null)
                    {
                        bool search = false;
                        foreach (object element in enumerable)
                        {
                            if (element.ToString() == projectId)
                            {
                                search = true;
                                break;
                            }
                        }
                        if (!search) currentGroupsID.Add(groupRef.Id); 
                    }
                }

            }
            Groups groups = new Groups(authentication.database);
            groups.groupsID = currentGroupsID;
            await groups.GetGroupsNames();
            currentGroups = groups.groupsNames;
        }
    }
}
