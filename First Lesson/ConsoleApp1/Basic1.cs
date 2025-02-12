using System;
internal class Basic1
{
    private static void ff(string[] args)
    {
        // Numeric data types
       int age = 24;
       Console.WriteLine("I am " + age + " years old");
       Console.WriteLine(int.MaxValue);
       Console.WriteLine(int.MinValue);
       long dream = 3000000L;
       Console.WriteLine("My dream is to earn " + dream + " dollars");
       Console.WriteLine(long.MaxValue);
       Console.WriteLine(long.MinValue);

       double negative = -123.456D;
       Console.WriteLine(negative);
       Console.WriteLine(double.MaxValue);
       Console.WriteLine(double.MinValue);

       float pi = 3.14159265358979323846264338327F;
       Console.WriteLine(pi);
       Console.WriteLine(float.MaxValue);
       Console.WriteLine(float.MinValue);

       decimal money = 10000000000000000000000000000.123456789012345678901234567890M;
       Console.WriteLine(money);
       Console.WriteLine(decimal.MaxValue);
       Console.WriteLine(decimal.MinValue);

       // Text based data types
       string name ="Mays"; // can be empty, double paranthesis
       char letter = 'M';  // cant be empty, single paranthesis
       Console.Write("My name is ");
       Console.WriteLine(name);
       Console.WriteLine(letter);


      // Converting string to numbers
      string ageText = "24";
      int ageNumber = Convert.ToInt32(ageText);
      Console.WriteLine(ageNumber);

      string bigText = "-90000000";
      long bigNumber = Convert.ToInt64(bigText);
      Console.WriteLine(bigNumber);

      string negativeText = "-123.456";
      double negativeNumber = Convert.ToDouble(negativeText);
      Console.WriteLine(negativeNumber);

      string piText = "3.14159265358979323846264338327";
      float piNuber = Convert.ToSingle(piText); 
      Console.WriteLine(piNuber);

      string moneyText = "10000000000000000000000000000.123456789012345678901234567890";
      decimal moneyNumber = Convert.ToDecimal(moneyText);
      Console.WriteLine(moneyNumber);




    }
}