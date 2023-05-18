using Google.Cloud.Firestore;
using Firebase.Auth;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography.X509Certificates;

namespace Quadriga
{
    public class Authentication
    {
        public FirestoreDb database;
        public FirebaseAuthProvider provider;
        public FirebaseAuthLink firebaseAuthLink;
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
        public Authentication(FirestoreDb database, User user)
        {
            this.database = database;
            provider = DatabaseHelper.provider;
            authStatus = false;
        }

        public async Task RegistrationOwner(string email, string password, string firstname, string middlename, string lastname)
        {
            regStatus = false;
            try
            {
                firebaseAuthLink = await provider.CreateUserWithEmailAndPasswordAsync(email, password, middlename);
                if (firebaseAuthLink.FirebaseToken == null)
                {
                    regStatus = false; ex = "Incorrect Email or Password";

                }
                else
                {
                    Dictionary<string, object> accountData = new()
                    {
                    {"email", email },
                    {"password", password },
                    {"lvl", 0 },
                    {"firstname", firstname },
                    { "middlename", middlename },
                    { "lastname", lastname },
                    { "jobtitle", ""},
                    { "groups", new List<string>()}

                };
                    await database.Collection("accounts").Document(email).SetAsync(accountData);
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
            ex = null;
            try
            {
                DocumentReference reference = database.Collection("accounts").Document(firebaseAuthLink.User.Email);
                DocumentSnapshot snapshot = await reference.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> userValues = snapshot.ToDictionary();
                    userValues.TryGetValue("lvl", out object lvl);
                    LVL = Convert.ToInt32(lvl);
                    ex = null;
                }
                else ex = "Database connection error";
            }
            catch(Exception ex)
            {
                this.ex = ex.Message;
            }
        }

        public async Task DeleteAccount()
        {
            try
            {
                DocumentReference reference = database.Collection("accounts").Document(firebaseAuthLink.User.Email);
                DocumentSnapshot snapshot = await reference.GetSnapshotAsync();
                if (snapshot.Exists)
                {
                    Dictionary<string, object> userValues = snapshot.ToDictionary();
                    userValues.TryGetValue("groups", out object groups);
                    {
                        if (groups == null)
                        {
                            await reference.DeleteAsync();
                            await provider.DeleteUserAsync(firebaseAuthLink.FirebaseToken);
                            ex = "Done";
                        }
                        else
                        {
                            MessageBox.Show("Delete all your groups before deleting your account");
                            ex = "Delete all your groups before deleting your account";
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                this.ex = ex.Message;
            }
        }

        public void LogOut()
        {
            firebaseAuthLink = null;
            LVL = -1;
            authStatus = false;
            ex = null;
        }

    }
}
