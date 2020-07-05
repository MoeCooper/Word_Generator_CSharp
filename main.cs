using System;
using System.Text;
using System.IO;

class MainClass 
{
    public static void Main (string[] args) 
    {
        Console.WriteLine("********MENU********");
        Console.WriteLine("1) Random Word");
        Console.WriteLine("2) Random Noun");
        Console.WriteLine("3) Random Verb");
        Console.WriteLine("4) Random Adjective");
        Console.WriteLine("9) EXIT PROGRAM");

        string UserInput = Console.ReadLine();
        Console.WriteLine(UserInput);

        string caseSwitch = UserInput;
        switch(caseSwitch) 
        {
            case "1":
                Console.WriteLine("This will get a random word from ALL WORDS.");
                break;
            case "2":
                Console.WriteLine("This will get a random word from NOUNS.");
                break;
            case "3":
                Console.WriteLine("This will get a random word from VERBS.");
                break;
            case "4":
                Console.WriteLine("This will get a random word from ADJECTIVES.");
                break;
            case "9":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Unknown Choice. Please choose 1, 2, 3, 4, or type 9 to exit.");
                break;
       }   
    }
}