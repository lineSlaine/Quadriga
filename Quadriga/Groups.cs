using Firebase.Auth;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Quadriga
{
    
    public class Groups
    {
        FirestoreDb database;
        public List<string> groupsNames;
        public List<String> groupsID;
        public Groups(FirestoreDb database)
        {
            this.database = database;
        }


        public async Task AddGroup(string groupName, FirebaseAuthLink firebaseAuthLink)
        {
            Dictionary<string, object> groupData = new()
            {
                {"groupname", groupName},
                {"projectid", new List<string>() }
            };
            DocumentReference addedDocRef = await database.Collection("groups").AddAsync(groupData);

            DocumentReference reference = database.Collection("accounts").Document(firebaseAuthLink.User.Email);
            await reference.UpdateAsync("groups", FieldValue.ArrayUnion(addedDocRef.Id));
        }

        public async Task GetGroupsNames()
        {
            groupsNames = null;
            List<string> names = new List<string>();

            foreach(string ID in groupsID)
            {
                DocumentReference reference = database.Collection("groups").Document(ID);
                DocumentSnapshot snapshot = await reference.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> groupValues = snapshot.ToDictionary();
                    groupValues.TryGetValue("groupname", out object name);
                    names.Add(name.ToString());
                }
            }
            groupsNames = names;
        }

        public async Task GetGroupsID(FirebaseAuth firebaseAuthLink)
        {
            groupsID = null;
            List<string> groupsIDlist = new List<string>();
            DocumentReference userReference = database.Collection("accounts").Document(firebaseAuthLink.User.Email);
            DocumentSnapshot snapshot = await userReference.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Dictionary<string, object> userValues = snapshot.ToDictionary();
                userValues.TryGetValue("groups", out object groupID);
                IEnumerable enumerable = groupID as IEnumerable;
                if (enumerable != null)
                {
                    foreach (object element in enumerable)
                    {
                        groupsIDlist.Add(element.ToString());
                    }
                }
            }
            groupsID = groupsIDlist;
        }
        public async Task DeleteGroup(string ID)
        {
            DocumentReference docRef = database.Collection("groups").Document(ID);
            await docRef.DeleteAsync();

            Query usersQuery = database.Collection("accounts");
            QuerySnapshot QuerySnapshot = await usersQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot userSnapshot in QuerySnapshot.Documents)
            {
                DocumentReference userReference = database.Collection("accounts").Document(userSnapshot.Id);
                await userReference.UpdateAsync("groups", FieldValue.ArrayRemove(ID));
            }

        }
        public async Task RenameGroup(string ID, string name)
        {
            DocumentReference docRef = database.Collection("groups").Document(ID);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"groupname", name}
            };
            await docRef.UpdateAsync(parameters);
        }

        public async Task AddNewUser(string ID, string email)
        {
            DocumentReference reference = database.Collection("accounts").Document(email);
            await reference.UpdateAsync("groups", FieldValue.ArrayUnion(ID));
        }
        public async Task RemoveUser(string ID, string email)
        {
            DocumentReference reference = database.Collection("accounts").Document(email);
            await reference.UpdateAsync("groups", FieldValue.ArrayRemove(ID));
        }
    }
}
