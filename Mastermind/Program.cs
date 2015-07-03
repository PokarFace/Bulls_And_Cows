using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Resources;
using System.Diagnostics;
using System.IO;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
           
            SoundPlayer _soundPlayer = new SoundPlayer("Tornado_Siren.wav");
            int[] numbersToGuess = new int[4];
            
            
            Random sequence = new Random();
            int bulls = 0;
            int cows = 0;
            _soundPlayer.SoundLocation = "Tornado_Siren.wav";

            Console.WriteLine("Let's play a game of Mastermind! ");
            Console.WriteLine("Input a 4 digit combination and I'll tell you");
            Console.WriteLine("how many you get correct and incorrect.");
            int gameTurns = 12;
            //String password;
            int[] passwordArray = new int [4];

            // Let's create a new sequence for P1 to guess.
            for (int i = 0; i <= 3; i++) 
            {
                numbersToGuess[i] = Convert.ToInt16(sequence.Next(9));
            }
            
            
          //  for (int i = 0; i <= 3; i++)
          //  {                
         //       Console.WriteLine("Enter a password of 4 digits ");
         //       string password = Console.ReadLine();                
         //   }
            //
            
            do
            {               
                gameTurns -= 1;
                Console.WriteLine("     You have " + (gameTurns) + " attempts left.");
                Console.WriteLine();            
                Console.WriteLine();

                string userEnteredPassword;
                Console.WriteLine("Enter a password of 4 digits ");
                userEnteredPassword = Console.ReadLine();
               
                int[] numbersFromPlayer = new int[4]; 

                for (int i = 0; i < userEnteredPassword.Length; i++)
                {
                    numbersFromPlayer[i] = Convert.ToInt16(numbersFromPlayer[i]);
                    Console.WriteLine(numbersFromPlayer[i]);
                }

              /*  foreach (char n in userEnteredPassword)
                {
                    numbersFromPlayer[n] = Convert.ToInt16(numbersFromPlayer[n]);
                    
                }*/
                

             
                             
               for (int o = 0; o < passwordArray.Length; o++)
                    {
                        if (numbersFromPlayer[o] == numbersToGuess[o]) //In case you guess it right
                        {
                            bulls += 1;
                        }
                        else if (numbersToGuess.Contains(numbersFromPlayer[0])) 
                        {
                            cows += 1;
                        };
                     }

                    if (bulls == 4)
                        {
                            Console.WriteLine("Congratulations! You broke the code!! ");
                            Console.ReadKey();
                           break;
                        }
                    else
                    {
                        Console.WriteLine("      You got " + bulls + " bulls, and " + cows + " cows.");
                        bulls = 0;
                        cows = 0;
                        Console.WriteLine();
                    };
                
            } while (gameTurns > 0 || bulls != 4);
              
            if (gameTurns < 1)
            {
                Console.WriteLine("You have been caught hacking the matrix!!! ");
                Console.ReadKey();
            }

            if (bulls == 4)
            {
                Console.WriteLine("Access to DataDine granted ");
                Console.WriteLine("Congratulations swordfish! ");
                Console.ReadKey();
            }
        }
    }
}

