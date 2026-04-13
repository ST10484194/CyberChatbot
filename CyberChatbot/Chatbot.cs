
namespace CyberChatbot
{
    // This class controls the chatbot behaviour
    public class Chatbot
    {
        // Property to store the user's name
        public string UserName { get; set; } = "";

        // Method that starts the chatbot
        public void Start()
        {
            Console.Clear();

            // Play the voice greeting
            AudioPlayer.PlayGreeting();

            // Show the chatbot logo
            UIHelper.ShowLogo();

            // Ask the user for their name
            AskName();

            // Start the chat loop
            ChatLoop();
        }

        // Method to ask the user for their name
        private void AskName()
        {
            Console.Write("Enter your name:");
            UserName = Console.ReadLine();

            // Check if the user entered an empty value
            while (string.IsNullOrWhiteSpace(UserName))
            {
                Console.Write("Name cannot be empty. Try again: ");
                UserName = Console.ReadLine();
            }

            // Display a personalised greeting
            UIHelper.TypingEffect("Hello " + UserName + "!");
            UIHelper.TypingEffect("I am your Cybersecurity Awareness Assistant.");
            UIHelper.TypingEffect("You can ask me related to cybersecurity.");
            UIHelper.TypingEffect("Type 'exit' anytime to close the chatbot.");
        }

        // Method to keep the chatbot running
        private void ChatLoop()
        {
            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine();

                // Check for empty input
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please type something.");
                    continue;
                }

                // Convert input to lowercase before checking
                input = input.ToLower();

                // Send the input to the response method
                Respond(input);
            }
        }

        // Method to respond to the user's questions
        private void Respond(string input)
        {
            if (input.Contains("exit") || input.Contains("quit") || input.Contains("bye"))
            {
                UIHelper.TypingEffect("Goodbye! Stay safe online 👋");
                Environment.Exit(0);
            }
            // Dictionary of responses (keyword → answer)
            var responses = new Dictionary<string, string>()
            { 
                { "virus", "A computer virus is a malicious program that spreads from one device to another and can damage files or steal information." },

                { "how are you", "I am functioning well and ready to assist you. As a chatbot, I am always available to help you learn about cybersecurity." },

                { "social engineering", "Social engineering is when attackers manipulate people into giving away confidential information." },

                { "data privacy", "Data privacy means protecting personal information from unauthorized access." },

                { "cyberbullying", "Cyberbullying is the use of digital platforms to harass or intimidate someone." },

                { "secure website", "A secure website usually uses HTTPS to protect data between the user and the website." },

                { "authentication", "Authentication is the process of verifying a user's identity before granting access." },

                { "purpose", "My purpose is to educate users about cybersecurity and help them understand how to stay safe online from threats like phishing and malware." },

                { "what can i ask you", "You can ask me about topics such as passwords, phishing, malware, safe browsing, and general cybersecurity awareness." },

                { "help", "I can assist you with understanding cybersecurity topics such as online safety, scams, and protecting your personal information." },

                { "malware", "Malware is any type of harmful software designed to damage, disrupt, or gain unauthorized access to a computer system." },

                { "phishing", "Phishing is a cyberattack where criminals trick you into revealing personal information by pretending to be a trusted source, such as a bank or company." },

                { "password", "A password is a secret code used to protect your accounts. Strong passwords should include letters, numbers, and symbols." },

                { "strong password", "A strong password is long, unique, and contains a mix of letters, numbers, and symbols to make it harder to guess or hack." },

                { "2fa", "Two-factor authentication (2FA) is a security process that requires two forms of identification, such as a password and a code sent to your phone." },

                { "firewall", "A firewall is a security system that monitors and controls incoming and outgoing network traffic to protect your device from unauthorized access." },

                { "antivirus", "Antivirus software is a program designed to detect, prevent, and remove malicious software from your computer." },

                { "spyware", "Spyware is malicious software that secretly collects information about you without your knowledge." },

                { "ransomware", "Ransomware is a type of malware that locks your files or system and demands payment to restore access." },

                { "cyberattack", "A cyberattack is an attempt by hackers to access, damage, or disrupt a computer system or network." },

                { "cybercrime", "Cybercrime refers to illegal activities carried out using computers or the internet, such as hacking or fraud." },

                { "hacker", "A hacker is a person who uses technical skills to gain unauthorized access to systems or data." },

                { "scam", "A scam is a dishonest scheme used to trick people into giving away money or personal information." },

                { "identity theft", "Identity theft occurs when someone steals your personal information and uses it without your permission." },

                { "data breach", "A data breach happens when sensitive information is accessed or exposed without authorization." },

                { "encryption", "Encryption is a method of protecting data by converting it into a code that only authorized users can read." },

                { "vpn", "A VPN (Virtual Private Network) protects your internet connection by encrypting your data and hiding your location." },

                { "public wifi", "Public Wi-Fi is a shared internet connection that can be unsafe because hackers may intercept your data." },

                { "safe browsing", "Safe browsing means using the internet carefully by avoiding suspicious links and only visiting trusted websites." },

                { "https", "HTTPS indicates that a website is secure and encrypts data between your browser and the website." },

                { "phishing email", "A phishing email is a fake message designed to trick you into clicking links or providing personal information." },

                { "fake website", "A fake website is a fraudulent site made to look real in order to steal your information." },

                { "online banking", "Online banking allows you to manage your finances online, but you must use secure networks and strong passwords." },
    
                { "cloud security", "Cloud security involves protecting data stored online by using encryption and strong access controls." },

                { "backup", "A backup is a copy of your data stored separately so you can recover it if it is lost or damaged." },

                { "password manager", "A password manager is a tool that securely stores and manages your passwords." },

                { "otp", "An OTP (One-Time Password) is a temporary code used to verify your identity during login." },

                { "cookies", "Cookies are small files stored on your device that track your browsing activity." },

                { "browser security", "Browser security involves keeping your browser updated and avoiding unsafe websites." },

                { "apps", "You should only install apps from trusted sources like official app stores to avoid malware." },

                { "phone security", "Phone security includes using a PIN, fingerprint, or face recognition to protect your device." },

                { "usb", "Unknown USB devices can contain malware and should not be used on your computer." },

                { "download", "Downloading files from untrusted sources can expose your device to malware." },

                { "social media", "Be careful what you share on social media, as attackers can use your information against you." },

                { "cybersecurity", "Cybersecurity is the practice of protecting systems, networks, and data from cyber threats." },

                { "threat", "A cyber threat is anything that can exploit a vulnerability and cause harm to a system." },

                { "risk", "Cyber risk is the possibility of a cyberattack causing damage or loss." },

                { "data protection", "Data protection involves safeguarding personal and sensitive information from unauthorized access." },

                { "online fraud", "Online fraud involves using the internet to deceive people and steal money or data." },

                { "security awareness", "Security awareness means understanding cyber risks and knowing how to avoid them." },

                { "dark web", "The dark web is a hidden part of the internet often used for anonymous and sometimes illegal activities." },

                { "login security", "Login security includes using strong passwords and enabling 2FA." },

                { "password reuse", "Password reuse is dangerous because if one account is hacked, others can also be accessed." },

                { "email safety", "Email safety involves avoiding suspicious emails and not clicking unknown attachments." },

                { "link safety", "Always check links before clicking to avoid phishing attacks." },

                { "update", "Updating software fixes security vulnerabilities and protects your device." },

                { "cyber safety", "Cyber safety means protecting yourself from online threats by following best practices." },

                { "online safety", "Online safety involves being cautious when using the internet and protecting your personal data." }
};

            // Check if any keyword matches user input
            foreach (var item in responses)
            {
                if (input.Contains(item.Key))
                {
                    UIHelper.TypingEffect(item.Value);
                    return;
                }
            }

            // Default response
            UIHelper.TypingEffect("I did not quite understand that. Could you rephrase?");
        }
    }
}