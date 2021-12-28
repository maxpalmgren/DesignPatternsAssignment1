using System;
using System.Collections.Generic;

namespace Design_Patterns_Assignment
{
    internal class Emails
    {
        public List<Observer1> Observers { get; set; }
        
        public Emails()
        {
            Observers = new();
        }

        public void RegisterObserver(Observer1 observer)
        {
            Observers.Add(observer);
        }

        public void UnRegisterObserver(Observer1 observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach(var observer in Observers)
            {
                observer.Update("This is the email");
            }
        }


        internal string Check()
        {
            var evenMinute = DateTime.Now.Minute % 2;
            if (evenMinute==0)
            {
                Notify();
            }
            return null;
        }
    }
}