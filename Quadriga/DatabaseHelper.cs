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
        private const string API_KEY = "AIzaSyDXhAzEMXzepCPjz8ps-Hs9PNg0zMKk05A";

        static string filepath = "";
        private static readonly string DatabaseConfig = @"
        {
         ""type"": ""service_account"",
         ""project_id"": ""quadriga-f25ff"",
         ""private_key_id"": ""2022313cdfe5ee950718f3f113cfae43d98b8df4"",
         ""private_key"": ""-----BEGIN PRIVATE KEY-----\nMIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCRSwYnM01hj7jH\n4xTjbgl87DeULceMb0+FGMKZZbGPYv5VRB9rUgbeOOLmKWJEiGPREUJHQXULydxL\nxzLDsLOdGuVsG1TYz3RqQ/7kumoBI8hDH6yYU6uYrwRIW6PTaBuqYfB7pt0NPkid\np4c9xObWRRmQJ2UH+cmPLimsE4dUzpz5buN8VzC8cmwYUNrVrjDoKC/r9hXG3mSG\nBjvFqgCsU2O2nTQ3oyFqxhtHpdS0oWlRGNucPHjtM7Ol51Ft2AF3vHkQAeGqYzb6\nmxZ+009FXEAP5OcivV3xTJ21KvkROBZD72xM7imTe6Q6pU5ggEQEUqNK5tMEEqD6\nxetvjv0bAgMBAAECggEAELnSyQN6Zn9NldE5796UgAmPcmL8xFlyDY/moxMWaDvM\nrJMtjMTCHqXs1PMxqVMMLp6ugxZxe3xu/Fg/q1B1tOHKRHI3B8iGDc+rEbi2CFCO\nts94JocHS4nmU9Ac4XLsMGaa8Rkp/GLNqDyHcKBwtHz67uHiGxNx1SZKzNDotOXx\nrXcHhJDNK9X6id5kFyVgVo6GBIrj4CZXUEK8egiccOmfg14tAO+48DqdSov/mebA\np77XmOD8PYAKWn+j+obbT6ogQhNc9ogt/YHLojqc+SOg4RLLRcknhAz7+0g/GB1V\nyXHKctEkEmPifAdzj9wSH05jp5S+gwAoNu1lOg+QXQKBgQDKxo0sWV3NTOIsFIti\nSyRc3YVFRjVEyy6mNzExXOaXSC22kGcz3dumlEo580JMeZY+yjR6SWIX2kv7KNj7\nnN1uXbL12vekfP2+QaJMTDPQfZig9CuHYcPFLoU8VZHg0Lidw2T8u2FI5gXF65NQ\nXhUGjuux9EIqUoz9UIYlXpk75QKBgQC3bfNGmRBNK/dBQihiUH+zO0hZe+9kCwiL\ncL7bqKMpASGkFvgUb0R4/Xyo8jaz9Ja5/dLpGFWiFosXXG46U2KU6pXboIynwuVc\nTFQuUDQPRW2JEAdWid80UK618J2cpHJxtMsdJOFJixsSEzdmL+Z2+j7aeCM0iTAo\nRLiIT73E/wKBgB/RwF1xOJL6uZMJNkYaXH5mFH+mYL2G1K8oggOo/FZI8UNwrYEq\nE0m0g2FMlt7BRZ5cxJdb5JSxoLKs2j/Bgc3LzkVeMvYQ1xB/5CPs4USaMNUw+5Om\n9719a1LoapfIqO+4taQjE0UJM2a3bMpzuQDqdHncRnW1toIZnLNIgOsxAoGBAIBt\nzU160f0WcXIRnjDn5+FX+pocukozp3HqKNenRUXqcuFu65dzKGAGK4gmvsJU2Eu1\nOjzWOu7YFd7vaoYP6BAYB4DU8mZrgSeUkcQzh5/BnqW+wUSIF+2LKChfJhuM0Exo\np2XqcoqJiRSou7sigpx/Lg7M2ulnvH4VT5axLk+FAoGAG8TiBCXKtOcewyw5xGLB\nX83YHyL3nsktKkV3neK8Kkt9ovt+8F1r1vY9MIp3p+GduZhEtw8iVNiQRQrfMcYN\nu40T2oX9ko/mcVKyD+ypjrpw//BFNbpwIC4LmGGTptjUy2PFbNmLlg107YbiFNj8\nx1aFQ3ftgutcS19hlyhfkTA=\n-----END PRIVATE KEY-----\n"",
         ""client_email"": ""firebase-adminsdk-ivrrv@quadriga-f25ff.iam.gserviceaccount.com"",
         ""client_id"": ""115498584195630798271"",
         ""auth_uri"": ""https://accounts.google.com/o/oauth2/auth"",
         ""token_uri"": ""https://oauth2.googleapis.com/token"",
         ""auth_provider_x509_cert_url"": ""https://www.googleapis.com/oauth2/v1/certs"",
         ""client_x509_cert_url"": ""https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-ivrrv%40quadriga-f25ff.iam.gserviceaccount.com""
        }";

        
        public static bool SetDatabase()
        {
            filepath = Path.Combine(Path.GetTempPath(), Path.GetFileNameWithoutExtension(Path.GetRandomFileName())) + ".json";
            File.WriteAllText(filepath, DatabaseConfig);
            File.SetAttributes(filepath, FileAttributes.Hidden);
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS",filepath);

            
            try
            {
                database = FirestoreDb.Create("quadriga - f25ff");
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
