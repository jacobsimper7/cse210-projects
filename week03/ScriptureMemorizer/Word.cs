// The key behaviors for the Word class are to hide and show a word and to check if a word is hidden or not. 
// In addition, a Word should have a behavior to get the display text of that word, which would be either the 
// word itself (for example, "prayer") or, if the word were hidden, this behavior would return underscores 
// (for example, "______").
public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initially, the word is not hidden.
    }

    public void Hide()
    {
        // This method will hide the word by replacing it with underscores.
        // For example, if the word is "prayer", it will be replaced with "______".
    }

    public void Show()
    {
        // This method will show the word by replacing the underscores with the actual word.
        // For example, if the word is "______", it will be replaced with "prayer".
    }

    public bool IsHidden()
    {
        // This method will check if the word is hidden or not.
        // It will return true if the word is hidden, and false otherwise.
        return false;
    }

    public string GetDisplayText()
    {
        // This method will return the display text of the word.
        // If the word is hidden, it will return underscores (for example, "______").
        // If the word is not hidden, it will return the actual word (for example, "prayer").
        return "";
    }
}