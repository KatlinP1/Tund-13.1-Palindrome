using System;

namespace Palindrome
{
    //palindrome ja matrix
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userInput = Console.ReadLine();

            if (IsPalindrome(userInput))
            {
                Console.WriteLine($"{userInput} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{userInput} is not a palindrome.");
            }
            
            
            Console.ReadKey();
        }

        public static bool IsPalindrome(string userString)
        {
            int j = userString.Length - 1;
            
            //Esimene variant palindromi tegemiseks
            /*for (int i = 0; i < userString.Length; i++)
            {
                if (userString[i] != userString[j])
                {
                    return false;
                }

                j--;
            }*/

            //palindoroomi teine variant, kuidas teha 
            for (int i = 0; i <= j / 2+1; i++, j--)
            {
                if (userString [i] != userString [j])
                {
                    return false;
                }
            }

            return true;
        }
    }
}