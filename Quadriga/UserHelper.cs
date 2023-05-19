using Google.Api;
using Google.Cloud.Firestore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Quadriga
{
    public class UserHelper
    {
        public List<string> currentUserID;
        public List<string> currentUserNames;
        public UserHelper()
        {
            currentUserID = new List<string>();
            currentUserNames = new List<string>();
        }
        public async Task getUsersIdInGroup(string groupId, FirestoreDb database)
        {
            currentUserID.Clear(); 

            Query accountQuery = database.Collection("accounts");
            QuerySnapshot QuerySnapshot = await accountQuery.GetSnapshotAsync();

            foreach (DocumentSnapshot accountSnapshot in QuerySnapshot.Documents)
            {
                DocumentReference accountRef = database.Collection("accounts").Document(accountSnapshot.Id);
                DocumentSnapshot snapshot = await accountRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> groupValues = snapshot.ToDictionary();
                    groupValues.TryGetValue("groups", out object groups);
                    IEnumerable enumerable = groups as IEnumerable;

                    if (enumerable != null)
                    {
                        bool search = false;
                        foreach (object element in enumerable)
                        {
                            if (element.ToString() == groupId)
                            {
                                search = true;
                                break;
                            }
                        }
                        if (search) currentUserID.Add(accountRef.Id);
                    }
                }
            }
        }
        public async Task getUsersNames(FirestoreDb database)
        {
            currentUserNames.Clear();

            foreach (string userID in currentUserID)
            {
                DocumentReference accountRef = database.Collection("accounts").Document(userID);
                DocumentSnapshot snapshot = await accountRef.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> accValues = snapshot.ToDictionary();
                    accValues.TryGetValue("firstname", out object firstname);
                    accValues.TryGetValue("middlename", out object middlename);
                    accValues.TryGetValue("lastname", out object lastname);
                    currentUserNames.Add(firstname.ToString() + " " + middlename.ToString() + " " + lastname.ToString());
                }
            }
        }

    }
}
