using System;

namespace PostApp {
    class Program {
        static void Main(string[] args) {
            var newPost = new Post {
                Title = "Hello world",
                Description = "Bla bla bla"
            };
            Console.WriteLine(newPost.Title);
            Console.WriteLine(newPost.Description);

            Console.WriteLine("This post was created: " +newPost.CreationDateTime);


            newPost.UpVote();
            newPost.UpVote();
            newPost.UpVote();
            newPost.UpVote();
            newPost.DownVote();
            Console.WriteLine("The post has " + newPost.displayVotes() + " votes");

        }
    }
}
