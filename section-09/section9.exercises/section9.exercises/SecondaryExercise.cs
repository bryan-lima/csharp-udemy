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
            #region Firs Post
            Comment firstPostFirstComment = new Comment("Have a nice trip");
            Comment firstPostSecondComment = new Comment("Wow that's awesome!");

            Post firstPost = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

            firstPost.AddComment(firstPostFirstComment);
            firstPost.AddComment(firstPostSecondComment);
            #endregion

            #region Second Post
            Comment secondPostFirstComment = new Comment("Have a nice trip");
            Comment secondPostSecondComment = new Comment("Wow that's awesome!");

            Post secondPost = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zealand", "I'm going to visit this wonderful country!", 12);

            secondPost.AddComment(secondPostFirstComment);
            secondPost.AddComment(secondPostSecondComment);
            #endregion

            Console.WriteLine(firstPost);
            Console.WriteLine(secondPost);
        }
    }
}
