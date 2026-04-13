using System;
namespace chatbot3
{
    namespace chatbot3
    {
        class Program
        {
            static void Main(string[] args)
            {
                // Greet the user with an audio message
                AudioPlayer.PlayerGreeting();
                // Display the chatbot logo
                chatbot.DisplayLogo();
                // Create a new user and get their name
                user user = new user();
                user.GetUserName();
                // Start the chatbot conversation
                chatbot bot = new chatbot(user);
                bot.StartChat();

                Console.ReadLine();



            }
        }
    }
}



