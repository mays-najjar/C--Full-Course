using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Basic2
    {

        static void Main(string[] args)
        {

            // Boolean data type 

            bool isFamale = true;
            bool isEmployee = false;
            Console.WriteLine(isFamale);
            Console.WriteLine(isEmployee);

            // Operators

            int age = 24;
            Console.WriteLine(age);
            age++;
            Console.WriteLine(age);
            age--;
            Console.WriteLine(age);
            age += 5;
            Console.WriteLine(age);
            // must be double or float to get the decimal point
            age /= 5;
            Console.WriteLine(age);
            float age2 = 24;
            age2 /= 5;
            Console.WriteLine(age2);

            string first = "My dream is living ";
            string second = "in Madina || Doha || Spain";
            first += second;
            Console.WriteLine(first);
            // cant be first -= second 
            // cant be first *= second
            // cant be first /= second

            char letter = 'M';
            letter += 'F'; // this is not MF its 77 + 70 = 147, and the result is a character 147 = ? 
            Console.WriteLine(letter);

            // suffix and prefix
            int x = 5;
            Console.WriteLine(x++); // first print then add
            Console.WriteLine(++x); // first add then print
           // Remainder
           






        }


    }
}