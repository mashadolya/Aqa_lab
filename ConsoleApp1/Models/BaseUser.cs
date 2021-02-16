using System;

namespace ConsoleApp1.Models
{
    public abstract class BaseUser
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public string FullName => FirstName + " " + LastName;

        public int Age { get; set; }


        public void ShowInfo()
        {
            Console.WriteLine($"Hello! I am {FullName} and I'am {Age} years old.");
        }
    }
}