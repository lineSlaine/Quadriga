﻿using Google.Cloud.Firestore;
using Firebase.Auth;

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
                    Dictionary<string, object> accountData = new Dictionary<string, object>
                {
                    {"email", email },
                    {"password", password },
                    {"lvl", 0 },
                    {"firstname", firstname },
                    { "middlename", middlename },
                    { "lastname", lastname },
                };
                    DocumentReference addDocUser = await database.Collection("accounts").AddAsync(accountData);
                    MessageBox.Show("Registration was successful!");
                    regStatus = true;
                    
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

        public async Task GetLVL()
        {

        }

    }
}
