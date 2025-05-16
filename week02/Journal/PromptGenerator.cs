public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What did you learn today?",
        "What was the best part of your day?",
        "What was the most challenging part of your day?",
        "What are you grateful for today?",
        "What is something you want to improve on tomorrow?",
        "How did your recieve your Saviors hand today?",
        "Why are you fighting? Why won't you just give up?",
        "What was a win from today? What do you lesrn from it?",
        "What was a loss today? How can you learn from it?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}