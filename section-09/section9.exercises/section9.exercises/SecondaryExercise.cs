using System;
using System.Collections.Generic;
using System.Text;
using section9.exercises.Entities;

namespace section9.exercises
{
    class SecondaryExercise
    {
        public static void Exercise()
        {
            Console.Write("\nNumber of posts: ");
            int postQuantities = int.Parse(Console.ReadLine());

            List<Post> postList = new List<Post>();

            for (int postNumber = 1; postNumber <= postQuantities; postNumber++)
            {
                Console.WriteLine($"\n\nPost #{postNumber}");
                Console.WriteLine("-------");
                Console.Write("Title: ");
                string postTitle = Console.ReadLine();

                Console.Write("Content: ");
                string postContent = Console.ReadLine();

                Console.Write("Likes: ");
                int postLikes = int.Parse(Console.ReadLine());

                DateTime postMoment = DateTime.Now;

                Post newPost = new Post(postMoment, postTitle, postContent, postLikes);

                Console.Write("\nNumber of comments: ");
                int commentsQuantities = int.Parse(Console.ReadLine());

                Console.WriteLine($"\nComments of post #{postNumber}");
                Console.WriteLine("-------------------\n");

                for (int commentNumber = 1; commentNumber <= commentsQuantities; commentNumber++)
                {
                    Console.Write($"Comment #{commentNumber}: ");
                    Comment comment = new Comment(Console.ReadLine());

                    newPost.AddComment(comment);
                }

                postList.Add(newPost);
            }

            Console.WriteLine("\n\n\n          FEED");
            Console.WriteLine("------------------------");

            foreach (Post post in postList)
            {
                Console.WriteLine(post);
            }
        }
    }
}
