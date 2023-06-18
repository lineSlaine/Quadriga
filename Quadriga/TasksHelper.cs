using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadriga
{
    public class TasksHelper
    {
        public List<string> currentTasksID;
        public List<string> currentTaskNames;
        public string description;
        FirestoreDb database;
        public TasksHelper(FirestoreDb database)
        {
            this.database = database;
        }

        public async Task CreateTask(string groupID, string projID, string descript, string name, string email)
        {
            Dictionary<string, object> taskData = new()
            {
                {"groupid", groupID},
                {"projectid", projID },
                {"taskdescription", descript},
                {"taskname", name},
                {"useremail", email},
            };
            DocumentReference addedDocRef = await database.Collection("tasks").AddAsync(taskData);

        }
        public async Task DeleteTask(string taskID)
        {
            DocumentReference docRef = database.Collection("tasks").Document(taskID);
            await docRef.DeleteAsync();
        }
        public async Task getTaskID(string email)
        {
            currentTasksID = new List<string>();
            Query tasksQuery = database.Collection("tasks").WhereEqualTo("useremail", email);
            QuerySnapshot snapshot = await tasksQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot document in snapshot.Documents)
            {
                currentTasksID.Add(document.Id);
            }
        }
        public async Task getTaskNames()
        {
            currentTaskNames = new List<string>();
            if (currentTasksID.Count != 0)
            {
                foreach (string ID in currentTasksID)
                {
                    DocumentReference documentReference = database.Collection("tasks").Document(ID);
                    DocumentSnapshot snapshot = await documentReference.GetSnapshotAsync();
                    if (snapshot.Exists)
                    {
                        Dictionary<string, object> taskValues = snapshot.ToDictionary();
                        taskValues.TryGetValue("taskname", out object name);
                        currentTaskNames.Add(name.ToString());
                    }
                }
            }
        }
        public async Task getDescription(string taskID)
        {
            description = null;
            DocumentReference docRef = database.Collection("tasks").Document(taskID);
            DocumentSnapshot snapshot = await docRef.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Dictionary<string, object> taskValues = snapshot.ToDictionary();
                taskValues.TryGetValue("taskdescription", out object descript);
                description = descript.ToString();
            }
        }
        //public async Task updateDescription(string newDesc)
        //{

        //}
    }
}
