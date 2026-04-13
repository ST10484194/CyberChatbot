using System;

public class Chatbot
{
    public string UserName { get; set; }

    public void start()
    {
        Console.Clear();

        // Play voice greeting
        AudioPlayer.PlayGreeting();

        // Display ASCII logo
        UIHelper.ShowLogo();

        // Ask user for their name
        AskName();

        // Start chatting loop
        ChatLoop();
    }

    // Method to ask for user's name
    private void AskName()
    {
        Console.Write("Enter your name: ");
        UserName = console.ReadLine();

        // Validate input (name cannot be empty)
        while (string.IsNullorwhitespace(UserName))
        {
            Console.Write("Name cannot be empty. Try again: ");
            UserName = ConsoleReadLine();
        }


        // Personalised greeting
        UIHelper.TypingEffect($"Hello {UserName}! 👋");
        UIHelper.TypingEffect("I'm your Cybersecurity Assistant.");
    }


    // Method that keeps the chatbot running
    private void ChatLoop()
    {
        while (true) // Infinite loop until user exits
        {
            Console.Write("\nYou: ");
            string input = Console.Readline().ToLower();

            // Check for empty input
            if (string.IsNullorwhitespace(input))
            {
                Console.WriteLine("Bot: Please type someting.");
                continue; // skip rest and ask again
            }

            // send input to response system
            Respond(input);
        }
    }
     // Method to handle chatbot responses
    private void Respond(string input)
    {
        if (input.contains("how are you"))
        {
            UIHelper.TypingEffect("I'm just code, but I'm running pefectly! 😂");
        }
        else if (input.contains("purpose"))
        {
            UIHelper.TypingEffect("I help you stay safe online by teaching you cybersecurity basics."


        }
        else if (input.contains("password"))
        {
            UIHelper.TypingEffect("Use strong passwords with numbers, symbols, and avoid personal info.");
        }
        else if (input.contains("pishing"))
        {
            UIHelper.TypingEffect("Be careful of suspicious emails asking for personal info.");
        }
        else if (input.contains("safe browsing"))
        {
            UIHelper.TypingEffect("Always check website URLS and avoid clicking unknown links.");
        }
        else if (input.contains("exit"))
        {
            UIHelper.TypingEffect("Goodbye! Stay safe online 👋");

            // close the program
            Environment.Exit(0);
        }
        else
        {
            // default response for unknown input
            UIHelper.TypingEffect("I didn't quite understand that. can you please rephrase?");
        }
    }
}