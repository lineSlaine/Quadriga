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
        public bool regStatus = false;
        public int LVL = -1;
        public string ex = null;

        public Authentication(FirestoreDb database)
        {
            this.database = database;
            provider = DatabaseHelper.provider;
            authStatus = false;
        }

        public async Task Registration(string email, string password, string firstname, string middlename, string lastname)
        {
            regStatus = false;
            //FirebaseAuthLink firebaseAuthLink = await provider.CreateUserWithEmailAndPasswordAsync("MeysamLoxPidor@gmail.com", "kek123123", "Monkey");
            try
            {
                firebaseAuthLink = await provider.CreateUserWithEmailAndPasswordAsync(email, password, middlename);
                if (firebaseAuthLink.FirebaseToken == null)
                {
                    regStatus = false; ex = "Incorrect Email or Password";

                }
                else
                {
                    regStatus = true;
                    Dictionary<string, object> accountData = new Dictionary<string, object>
                {
                    { "email", email },
                    {"password", password },
                    {"ID", 0 },
                    {"firstname", firstname },
                    { "middlename", middlename },
                    { "lastname", lastname },
                };
                    DocumentReference addDocUser = await database.Collection("accounts").AddAsync(accountData);
                    regStatus = true;
                    MessageBox.Show(addDocUser.Id.ToString());
                }
            }
            catch(Exception e)
            {
                ex = e.Message;
            }
        }

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
