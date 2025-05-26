# prog6221-poe-part-1-ST10452547
# Cybersecurity Awareness Chatbot

A simple yet intelligent console-based chatbot developed in C# to help users understand key cybersecurity concepts in an interactive, friendly way. This project includes dynamic responses, keyword recognition, sentiment detection, and memory features to simulate realistic conversation flow.

---

Features

- Keyword Recognition  
  Understands and responds to cybersecurity-related keywords like `password`, `phishing`, `scam`, `privacy`, and `safe browsing`.

- Dynamic Response System
  Provides at least 4 varied responses for each topic to make conversations feel more natural and less repetitive.

- Sentiment Detection
  Detects simple emotions like *worried*, *frustrated*, or *curious* and adjusts its tone to be more empathetic and supportive.

- Memory and Recall
  Remembers the user's name and favorite cybersecurity topic and uses that information later in the conversation for personalization.

- Natural Conversation Flow  
  Handles follow-up questions like “tell me more” or “I’m confused” and continues the discussion without restarting the conversation.

---

How It Works

The chatbot runs in a loop using a `while (true)` structure. It accepts user input, checks for various triggers (keywords, sentiments, personal info), and responds accordingly. It uses:

- `Contains()` for flexible keyword matching
- `Random` for varied responses
- `string` parsing to store user details
- Arrays for response storage
- Simple LINQ for sentiment keyword checks

---
Technology Used

- Language: C#
- Framework: .NET Console App
- IDE: Visual Studio / Visual Studio Code

---

This project is for educational purposes and coursework only.