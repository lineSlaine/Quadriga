using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Api;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Firebase.Auth;

namespace Quadriga
{
    internal class Authentication
    {
        FirestoreDb database;
        FirebaseAuthProvider provider;
        public bool authStatus; 

        public Authentication()
        {
            database = DatabaseHelper.database;
            provider = DatabaseHelper.provider;
        }

        public async void M()
        {
            FirebaseAuthLink firebaseAuthLink = await provider.CreateUserWithEmailAndPasswordAsync("MeysamLoxPidor@gmail.com", "kek123123", "Monkey");
        }

        public async void LoginWithEmailAndPassword(string email, string password)
        {
            try
            {
                FirebaseAuthLink firebaseAuthLink = await provider.SignInWithEmailAndPasswordAsync(email, password);
                authStatus = true;
            }
            catch 
            { 
                authStatus = false;
            }

        }
        
    }
}
