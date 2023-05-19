using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadriga
{
    public class UserHelper
    {
        List<string> currentUserID;
        List<string> currentUserNames;
        public UserHelper()
        {
            currentUserID = new List<string>();
            currentUserNames = new List<string>();
        }
        public async Task getUsersInGroup(string groupId, FirestoreDb database)
        {

        }
    }
}
