using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       Console.Write("Enter the year to check for leap year from: ");
       int year = Int32.Parse(Console.ReadLine());
      int count = 0;
      while(count != 20){
      if(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)){
         Console.WriteLine(year + " is a leap year.");
        count++;
         }
      year++;
        
            }
    }
}