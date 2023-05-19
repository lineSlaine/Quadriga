using Firebase.Auth;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Quadriga
{
    public class ProjectHelper
    {
        public List<string> projectsID;
        public List<string> projectsName;

        public ProjectHelper()
        {
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

        public async Task AddGroupInProject(string projectID, string groupID, FirestoreDb database)
        {
            DocumentReference docRef = database.Collection("groups").Document(groupID);
            await docRef.UpdateAsync("groups", FieldValue.ArrayUnion(projectID));
        }

        public async Task DeleteGroupInProject(string projectID, string groupID, FirestoreDb database)
        {
            DocumentReference docRef = database.Collection("groups").Document(groupID);
            await docRef.UpdateAsync("groups", FieldValue.ArrayRemove(projectID));
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
                await docReference.UpdateAsync("groups", FieldValue.ArrayRemove(projectID));
            }

        }
        public async Task GetProjectIDList(Authentication authentication, FirestoreDb database)
        {
            projectsID = null;

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
                    if(Convert.ToString(ownerEmail) == authentication.firebaseAuthLink.User.Email)
                    {
                        projectsID.Add(projReference.Id);
                    }
                }
            }
        }
        public async Task GetProjectNames(FirestoreDb database)
        {
            projectsName = null;
            if(projectsID != null)
            {
                foreach(string ID in projectsID)
                {
                    DocumentReference projReference = database.Collection("projects").Document(ID);
                    DocumentSnapshot snapshot = await projReference.GetSnapshotAsync();
                    Dictionary<string, object> projValues = snapshot.ToDictionary();
                    projValues.TryGetValue("projectname", out object name);
                    projectsName.Add(Convert.ToString(name));
                }
            }
        }
    }
}
