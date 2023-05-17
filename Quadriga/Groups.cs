using Firebase.Auth;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadriga
{
    public class Groups
    {
        FirestoreDb database;
        FirebaseAuthProvider provider;
        public Groups(FirestoreDb database)
        {
            this.database = database;
            provider = DatabaseHelper.provider;
        }


        public async Task AddGroup(string groupName, FirebaseAuthLink firebaseAuthLink)
        {
            Dictionary<string, object> groupData = new Dictionary<string, object>
            {
                {"groupname", groupName}
            };
            DocumentReference addedDocRef = await database.Collection("groups").AddAsync(groupData);

            DocumentReference reference = database.Collection("accounts").Document(firebaseAuthLink.User.Email);
            await reference.UpdateAsync("groups", FieldValue.ArrayUnion(addedDocRef.Id));
        }
    }
}
