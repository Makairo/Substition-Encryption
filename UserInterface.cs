using System;
using System.Collections.Generic;
using System.Text;

namespace Encryption
{
    public static class UserInterface
    {
        public static string Clean(string input)
        {
            string output = "";
            input = input.ToUpper();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] != ' ')
                {
                    output += input[i];
                }
            }
            return output;
        }

        public static char Clean(char input)
        {
            string x = input.ToString();
            x = x.ToUpper();
            return char.Parse(x);
        }

        public static string GetString()
        {
            string output = "";
            output = Console.ReadLine();
            if (String.IsNullOrEmpty(output))
            {
                return GetString();
            }
            foreach (char x in output)
            {
                if ((x < 32) || (x > 57 && x < 65) || (x < 97 && x > 90) || (x > 122))
                {
                    Console.WriteLine("Invalid message, please try again. Only use alpha characters: ");
                    return GetString();
                }
            }
            return output;
        }

        public static char GetChar()
        {
            char output = ' ';
            try
            {
                output = Char.Parse(GetString());
            }
            catch
            {
                GetChar();
            }
            return output;
        }

        public static int GetInt()
        {
            int output = 0;
            try
            {
                output = Int32.Parse(GetString());
            }
            catch
            {
                GetInt();
            }
            return output;
        }
    }
}
