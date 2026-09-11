using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person You interacted with today?",
        "What was the best part of Your day?",
        "How did You see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What made me laugh today?",
        "What am I grateful for today?"
    };

    private Random _random = new Random();
    private bool _firstTime = true;

    public string GetRandomPrompt()
    {
        if (_firstTime)
        {
            _firstTime = false;
            return _prompts[0];
        }
        int index = _random.Next(1, _prompts.Count);
        return _prompts[index];
    }
}