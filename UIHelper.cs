using System;
using System.Threading;

// This class handles all visual elements in the console 
public class UIHelper
{
	// Method to display ASCII Logo
	public static void ShowLogo()
	{
		// Change text colour to cyan
		Console.ForegroundColor = ConsoleColor.Cyan;

		Console.WriteLine("=======================================");
		Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT");
        Console.WriteLine("=======================================");
        Console.WriteLine("     [🔒 Stay Safe Online 🔒]");
		Console.WriteLine();

		// Reset colour back to default
		Console.ResetColor();
    }

	// Method to simulate  typing effect
	public static void TypingEffect(string message)
	{
		// Loop through each chaeracter in the message
		foreach (char c in message)
		{
			Console.Write(c);     // Print one character at  time
			Thread.Sleep(20);	  // Small delay to simulate typing	
		}
		Console.WriteLine();    // Move to next line
	}
}
