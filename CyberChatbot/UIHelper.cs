using System;
using System.Threading;

namespace CyberChatbot
{
    // This class handles the visual appearance of the chatbot
    public class UIHelper
    {
        // Method to display ASCII logo
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Multiline ASCII string
            string ascii = @"
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
          ______   ______  _____ ____  ____  _____ ____ _   _ ____  ___ _______   __         
 / ___\ \ / / __ )| ____|  _ \/ ___|| ____/ ___| | | |  _ \|_ _|_   _\ \ / /         
| |    \ V /|  _ \|  _| | |_) \___ \|  _|| |   | | | | |_) || |  | |  \ V /          
| |___  | | | |_) | |___|  _ < ___) | |__| |___| |_| |  _ < | |  | |   | |           
 \____| |_| |____/|_____|_| \_\____/|_____\____|\___/|_| \_\___| |_|_ _|_|_          
   / \ \      / / \  |  _ \| ____| \ | | ____/ ___/ ___|  | __ ) / _ \_   _|         
  / _ \ \ /\ / / _ \ | |_) |  _| |  \| |  _| \___ \___ \  |  _ \| | | || |           
 / ___ \ V  V / ___ \|  _ <| |___| |\  | |___ ___) |__) | | |_) | |_| || |           
/_/__ \_\_/\_/_/_  \_\_|_\_\_____|_| \_|_____|____/____/ _|____/ \___/_|_|   _ _____ 
/ ___|_   _|/ \\ \ / / / ___|  / \  |  ___| ____|  / _ \| \ | | |   |_ _| \ | | ____|
\___ \ | | / _ \\ V /  \___ \ / _ \ | |_  |  _|   | | | |  \| | |    | ||  \| |  _|  
 ___) || |/ ___ \| |    ___) / ___ \|  _| | |___  | |_| | |\  | |___ | || |\  | |___ 
|____/ |_/_/   \_\_|   |____/_/   \_\_|   |_____|  \___/|_| \_|_____|___|_| \_|_____|                                                                                                                                                                                                                                                                                                                                                                            
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             
";

            Console.WriteLine(ascii);

          
        }

        // Method to simulate a typing effect
        public static void TypingEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(15);
            }

            Console.WriteLine();
        }
    }
}