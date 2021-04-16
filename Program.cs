using System;
using static Encryption.UserInterface;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "";
            string sKey = "";
            string multiKey = "";

            string encryptedMessage1 = "";
            string encryptedMessage2 = "";
            string encryptedMessage3 = "";

            string decryptedMessage1 = "";
            string decryptedMessage2 = "";
            string decryptedMessage3 = "";

            // Grab User Input

            Console.WriteLine("Please enter plain text to be encrypted: ");
            message = UserInterface.GetString();
            Console.WriteLine("Please enter a single key: ");
            sKey = UserInterface.GetString();
            Console.WriteLine("Please enter a multi key: ");
            multiKey = UserInterface.GetString();

            Console.WriteLine("\n\n");

            // "Clean" the input

            message = UserInterface.Clean(message);
            sKey = UserInterface.Clean(sKey);
            multiKey = UserInterface.Clean(multiKey);

            // Print the cleaned inputs to user

            Console.WriteLine($"You entered [{message}] as your plain text message.");
            Console.WriteLine($"You entered [{sKey}] as your single key.");
            Console.WriteLine($"You entered [{multiKey}] as your multiKey");

            Console.WriteLine("\n\n");

            // Encrypt data on the string.
            // Prints data out the console on each go.

            encryptedMessage1 = Encrypt.SingleOrMultiKey(message, sKey);
            Console.WriteLine($"Your message with single key is: [{encryptedMessage1}]");
            encryptedMessage2 = Encrypt.SingleOrMultiKey(message, multiKey);
            Console.WriteLine($"Your message with multi key is: [{encryptedMessage2}]");
            encryptedMessage3 = Encrypt.ContinuousKey(message, multiKey);
            Console.WriteLine($"Your message with continuous is: [{encryptedMessage3}]");

            Console.WriteLine("\n\n");

            decryptedMessage1 = Decrypt.SingleOrMultiKey(encryptedMessage1, sKey);
            Console.WriteLine($"Decryped message with single key is: [{decryptedMessage1}]");
            decryptedMessage2 = Decrypt.SingleOrMultiKey(encryptedMessage2, multiKey);
            Console.WriteLine($"Decryped message with multi key is: [{decryptedMessage2}]");
            decryptedMessage3 = Decrypt.ContinuousKey(encryptedMessage3, multiKey);
            Console.WriteLine($"Decryped message with continuous is: [{decryptedMessage3}]");

        }
    }
}
