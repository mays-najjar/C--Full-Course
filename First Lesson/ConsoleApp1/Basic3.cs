using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Basic3
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

           /* Console.WriteLine("Hello My name is Ali!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "!");

            // ReadLine for string only
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age is " + age);

            Console.Write("Enter your salary: ");
            string salary = Console.ReadLine();
            double salaryDouble = Convert.ToDouble(salary);
            Console.WriteLine("Your salary is " + salaryDouble);

            if(age > 30){
                Console.WriteLine("You are old");
            } else {
                Console.WriteLine("You are young");
            }

            if(salaryDouble > 4000) {
                Console.WriteLine("Well paid");
            } else {
                Console.WriteLine("Poor");
            }

            if(age < 0 || age > 150){
                Console.WriteLine("Invalid age");
            } else if (age < 18){
                Console.WriteLine("Underage");
            } else if (age < 30){
                Console.WriteLine("Young");
            } else if (age < 50){
                Console.WriteLine("Middle age");
            } else {
                Console.WriteLine("Old");
            }
*/

            Console.WriteLine("Enter number of day");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day){
                case 1 : Console.WriteLine("Monday");
                break;
                case 2 : Console.WriteLine("Tuesday");
                break;
                case 3 : Console.WriteLine("Wednesday");
                break;
                case 4 : Console.WriteLine("Thursday");
                break;
                case 5 : Console.WriteLine("Friday");
                break;
                case 6 : Console.WriteLine("Saturday");
                break;
                case 7 : Console.WriteLine("Sunday");
                break;
                default : Console.WriteLine("Type number between 1-7");
                break;
            }
            Console.ReadLine();
        }
    }
}