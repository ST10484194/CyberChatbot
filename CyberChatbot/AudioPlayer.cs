using System;
using System.Media;

namespace CyberChatbot
{
    // This class is responsible for playing the voice greeting
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                // Create a SoundPlayer object and load the WAV file
                SoundPlayer player = new SoundPlayer("chatsound.wav");

                // Play the audio and wait until it finishes
                player.PlaySync();
            }
            catch (Exception)
            {
                // If the audio cannot play, show an error message
                Console.WriteLine("Could not play audio.");
            }
        }
    }
}
