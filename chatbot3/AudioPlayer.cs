using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace chatbot3
{
    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            string path = "C:\\Users\\User\\Desktop\\greeting.wav"; // Replace with the actual path to your audio file

            if (File.Exists(path))
            {
                SoundPlayer player = new SoundPlayer(path);
                player.Play();

            }
        }
    }
}
