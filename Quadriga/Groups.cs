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
                groupsNames = names;
            }
        }

        public async Task GetGroupsID(FirebaseAuth firebaseAuthLink)
        {
            DocumentReference userReference = database.Collection("accounts").Document(firebaseAuthLink.User.Email);
            DocumentSnapshot snapshot = await userReference.GetSnapshotAsync();
            if (snapshot.Exists)
            {
                Dictionary<string, object> userValues = snapshot.ToDictionary();
                userValues.TryGetValue("groups", out object groupID);
                IEnumerable enumerable = groupID as IEnumerable;
                if (enumerable != null)
                {
                    List<string> groupsIDlist = new List<string>();
                    foreach (object element in enumerable)
                    {
                        groupsIDlist.Add(element.ToString());
                    }
                    groupsID = groupsIDlist;
                }
            }
        }
        public async Task DeleteGroup(string ID)
        {
            DocumentReference docRef = database.Collection("groups").Document(ID);
            await docRef.DeleteAsync();

            Query usersQuery = database.Collection("accounts").WhereEqualTo("groups", ID);
            QuerySnapshot capitalQuerySnapshot = await usersQuery.GetSnapshotAsync();
            foreach (DocumentSnapshot userSnapshot in capitalQuerySnapshot.Documents)
            {
                DocumentReference userReference = database.Collection("accounts").Document(userSnapshot.Id);
                await userReference.UpdateAsync("groups", FieldValue.ArrayRemove(ID));
            }

        }
    }
}
