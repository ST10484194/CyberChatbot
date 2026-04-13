# CyberChatbot

## Project Overview
CyberChatbot is a C# console application developed for Part 1 of the Programming POE. It acts as a cybersecurity awareness chatbot that helps users learn about online safety and common cyber threats.

## Features
- Voice greeting using a WAV audio file
- ASCII art displayed at startup
- Personalised greeting using the user's name
- Cybersecurity awareness responses
- Input validation for empty or unsupported entries
- Exit feature using keywords like `exit`, `quit`, or `bye`
- Typing effect for a more interactive chatbot

## Cybersecurity Topics Covered
- Password safety
- Phishing
- Malware
- Viruses
- Public Wi-Fi safety
- Safe browsing
- Two-factor authentication
- Identity theft
- Social engineering
- Online scams

## How to Run the Project
1. Open the solution in Visual Studio.
2. Make sure the project targets `net8.0-windows`.
3. Ensure that `chatsound.wav` is included in the project.
4. Build and run the application.

## Project Structure
- `Program.cs` - Entry point of the application
- `Chatbot.cs` - Main chatbot logic and responses
- `UIHelper.cs` - ASCII art and typing effect
- `AudioPlayer.cs` - Voice greeting functionality
- `chatsound.wav` - Audio file for the chatbot greeting

## GitHub Actions CI
This project includes a GitHub Actions workflow that automatically restores and builds the project whenever changes are pushed to the repository.

## Author
Livhuwani Matsila