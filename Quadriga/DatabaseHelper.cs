using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Google.Api;
using Google.Cloud.Firestore;
using Firebase.Auth;

namespace Quadriga
{
    internal static class DatabaseHelper
    {  
        public static FirestoreDb database;
        public static FirebaseAuthProvider provider;
        private const string API_KEY = "AIzaSyA1_q_p49ZC5MU79RMDOBuBqS4Z3W3BcZE";

        static string filepath = "";
        private static readonly string DatabaseConfig = @"
        {
            //config here
        }";

        
        public static bool SetDatabase()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, DatabaseConfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS",filepath);

            
            try
            {
                database = FirestoreDb.Create("quadriga-a897b");
                provider = new FirebaseAuthProvider( new FirebaseConfig(API_KEY));
                return true;
            }
            catch
            {
                return false;
            }
            finally 
            { 
                File.Delete(filepath);
            }
        }

    }

}
