using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Api;
using Google.Cloud.Firestore;
using Firebase.Auth;

namespace Quadriga
{
    public class ProfileUpdater
    {
        public ProfileUpdater()
        {

        }



        public async Task UpdatePass(FirestoreDb database, Authentication authentication, string pass)
        {
            DocumentReference docRef = database.Collection("accounts").Document(authentication.firebaseAuthLink.User.Email);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"password", pass}
            };
            await docRef.UpdateAsync(parameters);
            authentication.provider.ChangeUserPassword(authentication.firebaseAuthLink.FirebaseToken, pass);
        }

        public async Task UpdateFN(FirestoreDb database, Authentication authentication, string firstN)
        {
            DocumentReference docRef = database.Collection("accounts").Document(authentication.firebaseAuthLink.User.Email);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"firstname", firstN }
            };
            await docRef.UpdateAsync(parameters);
        }
        public async Task UpdateMN(FirestoreDb database, Authentication authentication, string middleN)
        {
            DocumentReference docRef = database.Collection("accounts").Document(authentication.firebaseAuthLink.User.Email);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"middlename", middleN }
            };
            await docRef.UpdateAsync(parameters);
        }

        public async Task UpdateLN(FirestoreDb database, Authentication authentication, string lastN)
        {
            DocumentReference docRef = database.Collection("accounts").Document(authentication.firebaseAuthLink.User.Email);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"lastname", lastN }
            };
            await docRef.UpdateAsync(parameters);
        }
        public async Task UpdateJob(FirestoreDb database, Authentication authentication, string job)
        {
            DocumentReference docRef = database.Collection("accounts").Document(authentication.firebaseAuthLink.User.Email);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"jobtitle", job }
            };
            await docRef.UpdateAsync(parameters);
        }
        public async Task UpdateLVL(FirestoreDb database, Authentication authentication, string lvl)
        {
            DocumentReference docRef = database.Collection("accounts").Document(authentication.firebaseAuthLink.User.Email);
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"lvl", lvl }
            };
            await docRef.UpdateAsync(parameters);
        }
    }
}
