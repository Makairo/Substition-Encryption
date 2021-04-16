using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption
{
    public static class Encrypt
    {
        // Valid entries are ASCII 32 - 126

        public static string SingleOrMultiKey(string message, string key)
        {
            while(key.Length < message.Length)
            {
                key += key;
            }
            return EncryptMessage(message, key);
        }

        public static string ContinuousKey(string message, string key)
        {
            string baseKey = "WEATTACKATDAWN";
            key += baseKey;
            while (key.Length < message.Length)
            {
                key += key;
            }
            return EncryptMessage(message, key);
        }

        public static string EncryptMessage(string message, string key)
        {
            string eMessage = "";
            int x = 0;
            int y = 0;
            int z = 0;


            for (int i = 0; i < message.Length; i++)
            {
                x = message[i] - 64;
                y = key[i] - 64;
                z = x + y;
                if(z > 26)
                {
                    z = z - 26;
                }

                eMessage += (char)(z + 64);
            }
            return eMessage;
        }


        
    }

    public static class Decrypt
    {
        public static string DecryptMessage(string message, string key)
        {
            string eMessage = "";
            int x = 0;
            int y = 0;
            int z = 0;


            for (int i = 0; i < message.Length; i++)
            {
                x = message[i] - 64;
                y = key[i] - 64;
                z = x - y;
                if (z < 0)
                {
                    z = z + 26;
                }

                eMessage += (char)(z + 64);
            }
            return eMessage;
        }

        public static string SingleOrMultiKey(string message, string key)
        {
            while (key.Length < message.Length)
            {
                key += key;
            }
            return DecryptMessage(message, key);
        }

        public static string ContinuousKey(string message, string key)
        {
            string baseKey = "WEATTACKATDAWN";
            key += baseKey;
            while (key.Length < message.Length)
            {
                key += key;
            }
            return DecryptMessage(message, key);
        }
    }
}
