class Comment
{
    public string _userName;
    public string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    public string GetDisplayText()
    {
        // This method will return the display text of the comment.
        // It will include the user name and the text of the comment.
        return $"{_userName}: {_text}";
    }
}