// The key behaviors for the Scripture class are to hide random words and also to get the display 
// text as a string. (The "display text" refers to the text with some words shown normally, and 
// some replaced by underscores.) It would also be nice to have a behavior to check if the scripture 
// is completely hidden so that you know when to end the program.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string verseText)
    {
        _reference = reference;
        foreach (string word in verseText.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // This method will hide a random number of words in the scripture.
        // It will randomly select words to hide and replace them with underscores.
        // The number of words to hide is passed as a parameter.
        Random random = new Random();
        int count = 0;
        while (count < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                count++;
            }
        }
    }

    public string GetDisplayText()
    {
        // This method will return the display text of the scripture.
        // It will combine the book, chapter, and verse with the hidden words.
        // The hidden words will be replaced with underscores.
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        // This method will check if the scripture is completely hidden.
        // It will return true if all words are hidden, and false otherwise.
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayComparison(string userInput, string verseText)
    {
        string[] userWords = userInput.Split(' ');
        string[] verseWords = verseText.Split(' ');

        int max = Math.Max(userWords.Length, verseWords.Length);

        for (int i = 0; i < max; i++)
        {
            string verseWord = i < verseWords.Length ? verseWords[i] : "";
            string userWord = i < userWords.Length ? userWords[i] : "";

            if (verseWord.Equals(userWord, StringComparison.OrdinalIgnoreCase))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(verseWord + " ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write((userWord == "" ? "_" : userWord) + " ");
            }
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}