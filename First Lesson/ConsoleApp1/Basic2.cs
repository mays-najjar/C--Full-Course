using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Basic2
    {

        static void Fun ()
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
           int a = 10;
              int b = 3;
                Console.WriteLine(a % b); // 1
                Console.WriteLine(b % a); // 3
                Console.WriteLine(a % 2); // 0
                Console.WriteLine(b % 2); // 1

                // Exersize
                string name = "Mays";
                string phoneNumber = "0597405322";
                int age3 = 24;
                Console.WriteLine(name);
                Console.WriteLine(phoneNumber);
                Console.WriteLine(age3);
                var isMarried = false; 
                Console.WriteLine(isMarried);
                var email = "mays.najjar@gmail.com";
                Console.WriteLine(email);     
// odd even checker
                int a1 = 2;
                int b1 = 9 ;
                int c = b1 % a1;
                Console.WriteLine(c); // 1
                b1 = 10 ;
                c = b1 % a1 ; 
                Console.WriteLine(c); // 0






        }


    }
}