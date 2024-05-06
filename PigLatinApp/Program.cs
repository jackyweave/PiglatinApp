using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        string response;

        do
        { 


            Console.WriteLine("Enter a word/sentence to translate to Pig Latin!:");
            string userInput = Console.ReadLine().ToLower();
            
            
            string pigLatin = TranslateToPigLatin(userInput);

            Console.WriteLine(pigLatin);

            Console.WriteLine("Do you want to translate another word? (yes/no)");
            response = Console.ReadLine().ToLower();

            if (response != "yes" && response != "no")
            {
                Console.WriteLine("Invalid input. Exiting the program.");
                break;
            }
            else if (response != "yes")
            {
                Console.WriteLine("BYE! :( "); break;
          
            
            
            }
        
        
        } while (response == "yes");
    }
    

    



    static string TranslateToPigLatin(string word)
    { 

           

        string vowels = "aeiou";
        string result = " ";
        if (word.Contains("!")) { return "Hey that's not a word!"; } 
        else if (word.Contains("@")) { return word; }
        else if (word.Contains("#"))
        {
            return "Hey thats not a word!";
        } 
        else if (word.Contains("$"))
        {
            return "Hey that's not a word!";

        }


        else if (word.Contains("%"))
        {
            return "Hey that's not a word!";

        }

        else if (word.Contains("^"))
        {
            return "Hey that's not a word!";

        }

        else if (word.Contains("&"))
        {
            return "Hey that's not a word!";

        }


        else if (word.Contains("*"))
        {
            return "Hey that's not a word!";

        }

        else if (word.Contains("("))
        {
            return "Hey that's not a word!";

        }


        else if (word.Contains(")"))
        {
            return "Hey that's not a word!";

        }
        


        if (vowels.Contains(word[0]))
        { 
            result = word + "way";
        }
        else
        {
            int y = 0;
            foreach (char c in word)
                

            {
                
                if (vowels.Contains(c))
                {
                    break;
                }
                y++;
            }
            result = word.Substring(y) + word.Substring(0, y) + "ay";
        }

        return result;
    }

    
   
}
    
