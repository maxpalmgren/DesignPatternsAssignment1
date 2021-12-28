using Design_Patterns_Assignment.Strategy;
using System;

namespace Design_Patterns_Assignment
{
    internal class Strategy1
    {

        public static void Run()
        {
            MessageHandler messageHandler = new();
            SendEmail sendEmail = new();
            SendSMS sendSMS = new();
            SendFacebookMessage sendFacebookMessage = new();
            while (true) { 

            // Refactor this code so that it uses the strategy Pattern
            Console.WriteLine("Strategy");
            var message = "This is the message";

            Console.WriteLine("P: Send Message with chosen type");
            Console.WriteLine("E: Email");
            Console.WriteLine("S: SMS");
            Console.WriteLine("F: Facebook Messenger");
            char userInput = Console.ReadKey(true).KeyChar;
            switch (userInput)
            {
                case 'P' or 'p':
                    Console.Clear();
                    messageHandler.Send(message);
                    break;
                case 'E' or 'e' :
                    Console.Clear();
                    Console.WriteLine("sending by Email");
                    messageHandler.Message = sendEmail;
                    Console.ReadLine();
                    break;
                case 'S' or 's':
                    Console.Clear();
                    Console.WriteLine("sending by SMS");
                    messageHandler.Message = sendSMS;
                    Console.ReadLine();
                        break;
                case 'F' or 'f':
                    Console.Clear();
                    Console.WriteLine("sending by Facebook messenger");
                    messageHandler.Message = sendFacebookMessage;
                    Console.ReadLine();
                        break;
                default:
                    break;
            }
            }
        }
    }
}