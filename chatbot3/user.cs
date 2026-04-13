using System;
using System.Collections.Generic;
using System.Text;

namespace chatbot3
{
   public class user
    {
        // Property to store the user's name
        public string Name { get; set; }
        // Method to get the user's name with validation
        public void GetUserName()
        {
            // Prompt the user to enter their name
            Console.WriteLine("Enter your name");
            Name = Console.ReadLine();
            // Validate that the name is not empty
            while (string.IsNullOrEmpty(Name))
            {
                // If the name is empty, prompt the user to enter it again
                Console.Write("Name cannot be empty.  Try again:    ");
                Name = Console.ReadLine();
            }
            Console.WriteLine($"Hallo , {Name}!");
        }
    }
}
