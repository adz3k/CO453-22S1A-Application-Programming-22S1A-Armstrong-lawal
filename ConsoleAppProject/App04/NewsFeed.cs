using ConsoleAppProject.App04;
using System.Collections.Generic;
using System;

public class NewsFeed
{
    public const string AUTHOR = "Armstrong";
    private readonly List<Post> posts;

    ///<summary>
    /// Construct an empty news feed.
    ///</summary>
    public NewsFeed()
    {
        posts = new List<Post>();
        MessagePost messagePost = new MessagePost(AUTHOR, "I Love Manchester united ");
        AddMessagePost(messagePost);

        PhotoPost photoPost = new PhotoPost(AUTHOR, "Photo1.jpg", "Manchester united");
        AddPhotoPost(photoPost);
    }

    ///<summary>
    /// Add a text post to the news feed.
    /// 
    /// @param message The text post to be added.
    ///</summary>
    public void AddMessagePost(MessagePost message)
    {
        posts.Add(message);
    }

    ///<summary>
    /// Add a photo post to the news feed.
    /// 
    /// @param photo The photo post to be added.
    ///</summary>
    public void AddPhotoPost(PhotoPost photo)
    {
        posts.Add(photo);
    }

    ///<summary>
    /// Show the news feed. Currently: print the news feed details to the
    /// terminal. (To do: replace this later with display in a web browser.)
    ///</summary>
    public void Display()
    {
        // display all posts
        foreach (Post post in posts)
        {
            post.Display();
            Console.WriteLine();   // empty line between posts
        }
    }


}

        

