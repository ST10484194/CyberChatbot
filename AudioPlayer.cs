using System.Media;


// This class is responsible for playing the voice greeting 
public class AudioPlayer
{
	public static void playGreeting()
	{
		try
		{
			// Create a SoundPlayer object and load the WAV file
			soundPlayer player = new soundPlayer("chatbot.wav");

			// Play the audio and wait until it finishes
			player.playSync();  
		}
		catch (Exception)
		{

			// if the file is missing or error occurs, show message
			console.WriteLine("Could not play audio.");
		}
	}
	
}
