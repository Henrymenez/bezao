using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string newWord = "";
       Console.Write("Please Enter Word to be converted: ");
     string phrase = Console.ReadLine();
     if(string.IsNullOrEmpty(phrase)){
          Console.Write("Please Enter Word to be converted: ");
      phrase = Console.ReadLine();
     }else{
          string[] words = phrase.Split(' ');
        foreach (var word in words)
        {
            if(word.Length > 1){
              string res = word.Remove(1);
           string firstRemove = word.Remove(0,1);  
            
            
        string pigLatin = firstRemove + res + "ay";
         newWord = newWord + " " + pigLatin.ToLower();
            }
        }
         Console.WriteLine(newWord);
     }
       
    }
      
}