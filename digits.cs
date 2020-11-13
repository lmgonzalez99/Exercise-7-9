using System;
class Digits
{
    static void Main()
    {
       int OneDigit = 0, TwoDigits = 0, ThreeDigits = 0, MoreDigits = 0;
        Console.Write("Insert a number (write end to end): ");
        string InsetNumber = Console.ReadLine();
         while (InsetNumber != "end")
         {
            int input = Convert.ToInt32(InsetNumber);
                if (input != 0)
                {
                        if (input / 10 == 0)
                             OneDigit++;  
                             else
                        if (input / 100 == 0)
                            TwoDigits++;  
                             else
                         if (input / 1000 == 0)
                             ThreeDigits++; 
                                else
                            MoreDigits++;  
                }
            InsetNumber = Console.ReadLine();
          }
        Console.WriteLine("one digit: {0} two digits: {1} three digits: {2} more digits: {3}", OneDigit, TwoDigits, ThreeDigits, MoreDigits);
        Console.ReadLine();

    }
}
