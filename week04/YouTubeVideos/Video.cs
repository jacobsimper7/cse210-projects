class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); // <-- Add this line
    }

    public string GetDisplayText()
    {
        // This method will return the display text of the video.
        // It will include the title, author, length, and comments.
        string displayText = $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of comments: {_comments.Count}\nComments:\n";
        foreach (Comment comment in _comments)
        {
            displayText += $"- {comment.GetDisplayText()}\n";
        }
        return displayText.Trim();
    }

    public void AddComment(Comment comment)
    {
        // This method will add a comment to the video.
        // It will take a Comment object as a parameter and add it to the _comments list.
        _comments.Add(comment);
    }
}