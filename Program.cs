using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            {
                try
                {
                    string input = Console.ReadLine();

                    try
                    {
                        int convertedNumber;
                        bool isConvertedSuccessfully = int.TryParse(input, out convertedNumber);

                        if (!isConvertedSuccessfully)
                        {
                            throw new Exception("Conversion was not successful.");
                        }
                    }
                    catch (Exception ex) {
                        Console.WriteLine("There was an error with conversion: {0}", ex.Message);
                    }

                }
                catch (Exception ex) {
                    Console.WriteLine("There was an error: {0}", ex.Message);
                } finally {
                    Console.WriteLine("the rest of the application");
                }

                

                


            }
            Console.ForegroundColor = ConsoleColor.Red;

            {
                Console.Write("\nEnter your name: ");
                string user1 = Console.ReadLine().Trim();
                
                if (user1.Equals("Jon"))
                {
                    Console.WriteLine("Welcome, Jon!");
                }

                //do
                //{

                    Console.Write("Enter your age: ");
                    string user1Age = Console.ReadLine();
                    int age1;
                    int.TryParse(user1Age, out age1);

                //} while (true);

                
                //  switch statement
                switch (user1)
                {
                    case "Jon":
                        Console.WriteLine("Hey Jon!");
                        break;
                    case "jon":
                        Console.WriteLine("jonjonjon");
                        break;
                    default:
                        Console.WriteLine("Hello Guest.");
                        break;
                }
                //  printing user 1 info on screen
                Console.WriteLine("Your name is " + user1 + ", and you are " + age1 + " years old");
                Console.WriteLine();


                //  entering friend's name
                Console.Write("Enter your friend's name: ");
                string user2 = Console.ReadLine().Trim();


                //  entering friend's age
                Console.Write("Enter your friend's age: ");
                string user2Age = Console.ReadLine();
                int age2;
                int.TryParse(user2Age, out age2);


                //  beeps and clear screen after initial code performed
                Console.Clear();
                Console.Beep(4000, 100);
                Console.Beep(2000, 100);


                //  changing text color
                Console.ForegroundColor = ConsoleColor.Green;


                //  concat code from above
                Console.WriteLine("Your friend's name is " + user2 + ", and they are " + age2 + " years old");
                Console.WriteLine();
                int result = age1 + age2;
                Console.WriteLine("There are " + result + " years between the two of you");
            
                
            }
            {//  exit code block instruction
            Console.WriteLine("Hit any key to exit.");
            Console.ReadKey();
            }
            
        
        }
    }
}
