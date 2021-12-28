using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Decorators;
using System;

namespace Design_Patterns_Assignment
{
    internal class Decorator1
    {
        internal static void Run()
        {
            // Refactor this code so that it uses the Decorator Pattern
            Console.WriteLine("Decorator");
            Console.WriteLine("Please enter the text.");
            IDecorator text = new RegularText(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("B: Bold");
            Console.WriteLine("D: Deleted");
            Console.WriteLine("E: Emphasized");
            Console.WriteLine("I: Important");
            Console.WriteLine("Y: Inserted");
            Console.WriteLine("O: Italic");
            Console.WriteLine("M: Marked");
            Console.WriteLine("S: Smaller");
            Console.WriteLine("C: SubScript");
            Console.WriteLine("Z: SuperScript");
            Console.WriteLine("Q: EXIT");
            Console.WriteLine();
            Console.WriteLine("Press on the element you want to add");
            Console.WriteLine();
            Console.WriteLine("Press F to see your product");
            Console.WriteLine();            

            while (true)
            {
                // Get User Input
                var userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case 'f' or 'F':
                        Console.Clear();
                        Console.WriteLine($"Your HTML line is: {text.GetText()}");
                        break;
                    case 'b' or 'B':
                        Console.WriteLine("Adding Bold");
                        text = new Bold(text);
                        break;
                    case 'd' or 'D':
                        Console.WriteLine("Adding Deleted");
                        text = new Deleted(text);
                        break;
                    case 'e' or 'E':
                        Console.WriteLine("Adding Emphasized");
                        text = new Emphasized(text);
                        break;
                    case 'i' or 'I':
                        Console.Write("Adding Important");
                        text = new Important(text);
                        break;
                    case 'y' or 'Y':
                        Console.Write("Adding Inserted");
                        text = new Inserted(text);
                        break;
                    case 'o' or 'O':
                        Console.Write("Adding Italic");
                        text = new Italic(text);
                        break;
                    case 'm' or 'M':
                        Console.Write("Adding Marked");
                        text = new Marked(text);
                        break;
                    case 's' or 'S':
                        Console.Write("Adding Small");
                        text = new Smaller(text);
                        break;
                    case 'c' or 'C':
                        Console.Write("Adding Subscript");
                        text = new Subscript(text);
                        break;
                    case 'z' or 'Z':
                        Console.Write("Adding Superscript");
                        text = new Superscript(text);
                        break;
                    case 'q' or 'Q':
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}