using System;

namespace AnotherProject_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var stringArray = new string[5];
            int[] applye = new int[5];
            // Console.WriteLine(stringArray[0]);

            //using string Format
            string firstName = "Angat";
            string middleName = "Nath";
            string lastName = "Yogi";
            string fullName = string.Format("{0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine(fullName);
            
            //using string join

            var numbers = new int[3] { 0, 1, 2 };
            string list = string.Join(",", numbers);
            Console.WriteLine(list);
            Console.WriteLine(list[1]);

            Console.WriteLine("Enter a string >>");
            string userInput = Console.ReadLine();
            int i = 0;
            if (userInput.Contains("{"))
            {

            while (userInput[i]!='{')
            {
                i++;
                
            }
            int j = i + 1;
            //Console.WriteLine(userInput[j]);
            while (userInput[j]!='}')
            {
                j++;
               
            }
            //Console.WriteLine(userInput[j-1]);
            Console.WriteLine(userInput.Substring(i+1,j-(i+1)));
            }
            else
            {
                Console.WriteLine("It does not contain any braces");
            }

            
        }
    }
}
