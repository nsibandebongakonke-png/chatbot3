using System;
using System.Threading;


namespace chatbot3

{
    public class chatbot
    {
        private user _user;

        public chatbot(user user)
        {
            this._user = user;

        }
        public static void DisplayLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"










"};        
        public void StartChat()
        {
            Console.WriteLine("\nHi{user Name},How can I assist you today?");
            while (true)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.Write("You: ");
                Console.Write("\nYou:    ");
                Console.ResetColor();

                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enter a valid input.");
                    continue;
                }
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))                   
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }


                string userInput = Console.ReadLine();
                if (string.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Please enter a valid input.");
                    continue;
                }
                if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                Console.WriteLine("Processing your request...");
                Thread.Sleep(1000);
                Console.WriteLine($"You said: {userInput}");
            }
        }
    }
}