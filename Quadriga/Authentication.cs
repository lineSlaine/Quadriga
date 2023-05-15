using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Api;
using Google.Cloud.Firestore;
using Google.Cloud.Firestore.V1;
using Firebase.Auth;
using System.ComponentModel;

namespace Quadriga
{
    public class Authentication
    {
        FirestoreDb database;
        FirebaseAuthProvider provider;
        FirebaseAuthLink firebaseAuthLink;
        public bool authStatus;
        public int LVL = -1;
        public string ex = null;

        public Authentication()
        {
            database = DatabaseHelper.database;
            provider = DatabaseHelper.provider;
            authStatus = false;
        }

        //public async void M()
        //{
        //    FirebaseAuthLink firebaseAuthLink = await provider.CreateUserWithEmailAndPasswordAsync("MeysamLoxPidor@gmail.com", "kek123123", "Monkey");
        //}

        public async Task LoginWithEmailAndPassword(string email, string password)
        {
            
            try
            {
                firebaseAuthLink = await provider.SignInWithEmailAndPasswordAsync(email, password);


                if (firebaseAuthLink.FirebaseToken == null)
                {
                    authStatus = false; ex = "Incorrect Email or Password";
                }          
                else authStatus = true;

            }
            catch(Exception e)
            {
                ex = e.Message;
                
                authStatus = false;
            }
            finally
            {
                //
            }
        }

    }
}
