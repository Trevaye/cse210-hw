// Class representing a comment on a video
public class Comment
{
    // Properties to store the name of the person and the comment text
    public string Name { get; set; }
    public string Text { get; set; }

    // Constructor to initialize the comment object
    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }
}