﻿namespace HelloMethods
{
    public class Message
    {
        public static string GetMessage(string lang)
        {
            if (lang.Equals("sp"))
            {
                return "Hola Mundo";
            }
            else if (lang.Equals("fr"))
            {
                return "Bonjour le monde";
            }
            else if (lang.Equals("jp"))
            {
                return "Kon'nichiwa sekai";
            }
            else
            {
                return "Hello World";
            }
        }
    }
}