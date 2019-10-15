using System;
using System.Collections.Generic;
using System.Text;

namespace OOPS.CommercialDataLinkedList
{
    class Utility
    {
        public static bool ContainsCharacter(string username)
        {
            try
            {
                char[] typeCharacter = username.ToCharArray();
                for (int i = 0; i < typeCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(typeCharacter[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw new Exception(ex.Message);
            }
            return true;
        }
        public static bool ConatainsDigit(string username)
        {
            try
            {
                char[] nameDigit = username.ToCharArray();
                for (int i = 0; i < nameDigit.Length;i++)
                {
                    if (char.IsDigit(nameDigit[i]))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static bool CheckString(string name)
        {
            try
            {
                //// Removing all  white space character from the current string object. 
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public static bool IsNumber(string input)
        {
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) == false)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public static string pathData()
        {
            string path = (@"C:\Users\Bridgelabz\source\repos\OOPS\CommercialData\CommercialList.json");
            return path;
        }
    }
}
