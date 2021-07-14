using System;

namespace HelloMethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string message = Message.GetMessage("jp");
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}