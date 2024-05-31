public class Video
{
    // Properties to store the title, author, and length of the video
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds

    // List to store comments associated with the video
    private List<Comment> comments;

    // Constructor to initialize the video object
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    // Method to get the number of comments on the video
    public int GetCommentCount()
    {
        return comments.Count;
    }

    // Method to get the list of comments on the video
    public List<Comment> GetComments()
    {
        return comments;
    }
}