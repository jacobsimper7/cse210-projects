// The Reference class is pretty simple as far as behaviors go. It should have the ability to get the display 
// text of the reference, which is just a string combining the book, chapter, and verse (or verses). You could 
// consider having getters and setters for each of the data elements that this class stores, but it may be even 
// better to use a constructor to set them.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse; // If only one verse is provided, start and end are the same.
    }

    public string GetDisplayText()
    {
        if (_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }
}