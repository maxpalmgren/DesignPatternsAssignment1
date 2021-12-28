using Design_Patterns_Assignment;
using Design_Patterns_Assignment.Repository;
using System;

namespace Design_Patterns_Assignment
{
    internal class Repository1
    {
        internal static void Run()
        {
            DataRepository db = new();
            // Refactor this code so that it uses the Repository Pattern
            Console.WriteLine("Repository");
            var data = db.GetAllData("Dataset A");
            var customer = db.GetAllData("From Table Customer Where Name==Steve"); // this is a search
            var animal = db.GetAllData("From Table Animal Where Owner==Steve"); // this is a search
            db.SaveData(data);
            db.SaveData(customer);
            db.SaveData(animal);
            Console.WriteLine();
        }
    }
}