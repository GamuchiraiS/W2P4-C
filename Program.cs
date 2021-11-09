using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int letters, digits, StringLength, index;
            letters = digits = StringLength = index = 0;
            //Ask user to input string
            Console.WriteLine("Enter a string: ");
            //Capture user input and assign it's value
            //to str
            str = Console.ReadLine();
            //Checks length of str
            StringLength = str.Length;
            //Makes string lowercase
            str = str.ToLower();

            //runs when the index is less than the length of the string
            while (index < StringLength)
            {
                //if the letter is between a - z
                //then increment letters
                if ((str[index] >= 'a' && str[index] <= 'z'))
                {
                    letters++;
                }
                //and if digits are between 0 - 9
                //then increment digits
                else if (str[index] >= '0' && str[index] <= '9')
                {
                    digits++;
                }
                index++; //increments so we can move through each letter
            }

            Console.WriteLine("Numbers of letters: " + letters);
            Console.WriteLine("Numbers of digits: " + digits);
            Console.ReadLine();
        }
    }
}
