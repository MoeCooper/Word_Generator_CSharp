using System;
using System.Text;
using System.IO;

class MainClass 
{

    static void MenuChoice(string UserInput)
    {
        Console.WriteLine("********MENU********");
        Console.WriteLine("1) Random Word");
        Console.WriteLine("2) Random Noun");
        Console.WriteLine("3) Random Verb");
        Console.WriteLine("4) Random Adjective");
        Console.WriteLine("9) EXIT PROGRAM");
    }


    public static void Main (string[] args) 
    {

        string UserInput = Console.ReadLine();
        string caseSwitch = UserInput;

        while (UserInput !="9")
        {
            switch(caseSwitch) 
            {
                case "1":
                    Console.WriteLine("This will get a random word from ALL WORDS.");
                    MenuChoice(UserInput);
                    break;
                case "2":
                    Console.WriteLine("This will get a random word from NOUNS.");
                    MenuChoice(UserInput);
                    break;
                case "3":
                    Console.WriteLine("This will get a random word from VERBS.");
                    MenuChoice(UserInput);
                    break;
                case "4":
                    Console.WriteLine("This will get a random word from ADJECTIVES.");
                    MenuChoice(UserInput);
                    break;
                case "9":
                    Console.WriteLine("Exiting program.... Goodbye!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Unknown Choice. Please choose 1, 2, 3, 4, or type 9 to exit.");
                    MenuChoice(UserInput);
                    break;
            }
        }  
    }
}