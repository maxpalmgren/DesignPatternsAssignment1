using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment
{
    class Observer1
    {
        public void Update(string email)
        {
            Console.WriteLine(email);
        }
        internal static void Run()
        {
            // Refactor this code so that it uses the Observer Pattern
            Console.WriteLine("Observer");
            Observer1 observer = new();
            Emails emails = new();

            while (true)
            {
                Console.WriteLine("Press S to add/remove observer");
                Console.WriteLine("Press U to update (only works at even minutes)");
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;

                switch (userInput)
                {
                    case 'u' or 'U':
                        emails.Check();
                        break;

                    case 's' or 'S':
                        if (emails.Observers.Contains(observer))
                        {
                            emails.UnRegisterObserver(observer);
                            Console.WriteLine("Observer Unregistered");
                        }
                        else
                        {
                            emails.RegisterObserver(observer);
                            Console.WriteLine("Observer Registered");
                        }
                        break;

                    case 'e' or 'E':
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Write("That is not a valid choice");
                        break;
                }
            }
        }
    }
}
