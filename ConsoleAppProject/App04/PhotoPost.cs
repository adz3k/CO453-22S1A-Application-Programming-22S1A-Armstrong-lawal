using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Armstrong
    /// @version 0.1
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        public string Filename { get; }

        // a one line image caption
        public string Caption { get; }


        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(string author, string filename, string caption) : base(author)
        {
            Filename = filename;
            Caption = caption;
        }

        public override void Display()
        {
            Console.WriteLine($"    Filename: [{Filename}]");
            Console.WriteLine($"    Caption: {Caption}");
            base.Display();
        }
    }
}
