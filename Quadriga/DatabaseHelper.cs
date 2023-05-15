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
            ""type"": ""service_account"",
            ""project_id"": ""quadriga-a897b"",
            ""private_key_id"": ""061ccd5a84d2735a5e72c31e7ff94b259c1494e4"",
            ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvAIBADANBgkqhkiG9w0BAQEFAASCBKYwggSiAgEAAoIBAQDru3Hp/iyWjoj7\nr69mzkyN+X/rmnljguFipnRYaQpWKfctcjiWtl8lVI3VSOvLD+It+Xi+f06/ba9V\nTjfvJm/k6Z5MTV77n4wxUzxXjVuUOHGjtqvZmNCsf7KulvhYhGDxhOMC6NHvbl5U\nTUMLlAnEz6LDwwhNrSORiEGnOWLZ5wxSJad+qeS0l5fEww8L7Bip+EWZpywy8PpQ\nC/CABrNqBsnBtgWmgno0PqlFuEYDvZ3swzyrkAtrwilpe+othIn+TEkxReSYhl+S\npCIewdcL6jtb/loMqfJA+gXp/4cvMqupLi83uSqOoOU2jnVv3q8Hrsh5KIExpR1+\ntL/wOnGXAgMBAAECggEAaMzcx/qIOCcGH17ry/jLcBMMG+KBNQxqx0DZWLTaM5RU\nn4+4OMi7ZA1DQR86NPzKwUW3uHlAuTo6SOKNW3TrKgnypll/cL5txUAMA6CEplCx\ntObxX7vgic/70EKuBixULQu3IQQA0UFwDmqK9ArMjQMCiaWbe20N8xVwmreYiuai\n1AaAaizyBlhrfZPTMuOmprv61VuaiORi4TqrXoqrk0yzKHFzMHMZ28tNN4MD603U\njZRWejWBHmyPvus+JjnZ4rWXcGFn43ZrIj+EFXa4GdMblRPvYrfKlb9+DNaXAY8V\nWiFuS9cpQ/Ky7QeJTtc0R3wfqpOETzOXO58wIVTzAQKBgQD3sEpzAx+pl2zBftMP\n2OdRyCxts46OCE+HUGWuzVVUFZsfZWZNaeOUp1+AY4PWql0wgwL93esCSDA8FYqM\nH3mPLsftsS+A13i/413i6Zs+m1bEPyzDLwVUU7Pg+QphfUeK2r0+U0lpz3gNkQyE\njlli7nxBz1UeeCGHSTew3dxcnwKBgQDzpHICteecXipCMAM/8tpgumkAF/I9aBMT\noncNChT0yU/p/8SU7xrMrU0EBsEOpLabAIR2WJM5Cv0RE1GxID+Oc7i0k7D1Er8M\n+zxZu9/Dc/36oCBqqiB+UUeoRvP9IsCclAo99I424O9IrUnLAiGY3iY7iJ7RVsGG\n5HTxQ4bQCQKBgBql+eyT2nU5mHbc+UJMON8ApV8MIXtAg6XwTXBYISURygW/uBj+\nGoEk3M6IZmfTHoGYptq/ZIhzUdU1EBnxTPfNta7qEE1RYWlrwe8m6Q/8UIJ+tYcu\naOlgtAqxYJ+Khgb3b8Lj3RMoQidbgrhERHOzauT9tI+5pwnSI87An/PLAoGAf80N\nxOA4OqymTAu1WLEB3eVKOLNW7OEPyKfa/OsB7RlAIwV3z4vQqfZpxKfqUs0RwCK4\nWP/DUhOyhWd13YyF6ipHg+lI1HTd5GhQ0t0a1gKdAf9GoczVuIzYIqv9RhYZpMh+\nytriUmUQ/zVu1N8sUmyM74ONk0+HukNSGFAMgkkCgYBpb/j3kDK6peowtL6km81/\nrlbI7kPG6johxNoBp9sdBKpcyOCk1fCe01321UwJa+fpvK2Pnvx3rPOKGGhIIQMS\nLU/5q+D4zpXAWy9dK8/iTbHPPkoDhP4Q+qIQlEgyELO8mH8i5f7ckE6UIfQ4/u1E\nd7R0laCZiwJvPo5XWhsAVQ==\n-----END PRIVATE KEY-----\n"",
            ""client_email"": ""firebase-adminsdk-6f586@quadriga-a897b.iam.gserviceaccount.com"",
            ""client_id"": ""108887256436397642655"",
            ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
             ""token_uri"": ""https://oauth2.googleapis.com/token"",
            ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
            ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-6f586%40quadriga-a897b.iam.gserviceaccount.com"",
            ""universe_domain"": ""googleapis.com""
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
