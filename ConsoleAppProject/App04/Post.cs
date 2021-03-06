using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{
    /// <summary>
    /// The post class is the parent class that contains 
    /// similar methods that will be used/inherit 
    /// by the message and photo post (child) class. 
    /// </summary>
    /// <author>
    /// Ali Hassan 22/04/22
    /// </author>
    public class Post
    {
        public int PostId { get; }

        private int likes;

        private readonly List<String> comments;

        // username of the post's author
        public String Username { get; }

        public DateTime Timestamp { get; }

        public static int instances = 0;

        /// <summary>
        /// constructor of the class post
        /// </summary>
        public Post(string author)
        {
            instances++;
            PostId = instances;
            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        /// <summary>
        /// Record one more 'Like' indication from a user.
        /// </summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// </summary>
        /// <param name="text">
        /// The new comment to add.
        /// </param>        
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        ///  The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>      
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

        ///<summary>
        /// Display the details of this post.
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"\tPost ID:\t {PostId}");
            Console.WriteLine($"\tAuthor:\t\t {Username}");
            Console.WriteLine($"\tTime Elpased:\t {FormatElapsedTime(Timestamp)}");
            Console.WriteLine($"\tDate Posted:\t {Timestamp.ToLongDateString()}");
            Console.WriteLine($"\tTime Posted:\t {Timestamp.ToLongTimeString()}");
            Console.WriteLine("----------------------------------------------------");

            if (likes > 0)
            {
                Console.WriteLine($"\tLikes:  {likes}  people like this.\n");
            }
            else
            {
                Console.WriteLine();
            }

            if (comments.Count == 0)
            {
                Console.WriteLine("\tNo comments.\n");
            }
            else
            {
                Console.WriteLine($"\t{comments.Count}  comment(s). Click here to view.\n");
                foreach (string comments in comments)
                {
                    Console.WriteLine($"\tComment: {comments}\n");
                }
            }
        }

        /// <summary>
        /// Counts and return the actual number of post
        /// </summary>
        public static int GetNumberOfPosts()
        {
            return instances;
        }
    }
}