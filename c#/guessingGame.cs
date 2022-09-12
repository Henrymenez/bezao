using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string secretNumber ="15";
        string guess = "";
        int guessCount = 0;
        int guessLimit = 3;
        bool outOfGuesses = false;
        Console.Write("Enter a Number: ");
            guess = Console.ReadLine();
        while(guess != secretNumber && !outOfGuesses){
            if(guessCount < guessLimit){
                if(Int32.Parse(guess) > Int32.Parse(secretNumber)){
                    Console.WriteLine("Too High");
                  Console.Write("Enter a Number: ");
            guess = Console.ReadLine();
            guessCount++;   
                }else{
                    Console.WriteLine("Too Low");
                  Console.Write("Enter a Number: ");
            guess = Console.ReadLine();
            guessCount++;   
                }
            }else{
                outOfGuesses = true;
            }
        }
        if(outOfGuesses){
            Console.WriteLine($"You Lost, you had {guessLimit} number of trials");
        }else{
             Console.WriteLine("You Won");
        }
       
    }
}