// The key behaviors for the Scripture class are to hide random words and also to get the display 
// text as a string. (The "display text" refers to the text with some words shown normally, and 
// some replaced by underscores.) It would also be nice to have a behavior to check if the scripture 
// is completely hidden so that you know when to end the program.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

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
    }

    public string GetDisplayText()
    {
        // This method will return the display text of the scripture.
        // It will combine the book, chapter, and verse with the hidden words.
        // The hidden words will be replaced with underscores.
        return "";
    }

    public bool IsCompletelyHidden()
    {
        // This method will check if the scripture is completely hidden.
        // It will return true if all words are hidden, and false otherwise.
        return false;
    }
}