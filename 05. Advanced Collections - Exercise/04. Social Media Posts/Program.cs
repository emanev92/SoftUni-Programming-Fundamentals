using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Social_Media_Posts
{
    class Program
    {
        public static void Main()
        {
            var postLike = new Dictionary<string, int>();
            var postDislike = new Dictionary<string, int>();
            var commentDict = new Dictionary<string, Dictionary<string, string>>();

            string commandLine = Console.ReadLine();

            var comment = new List<string>();

            while (!commandLine.Equals("drop the media"))
            {
                var data = commandLine.Split(' ');
                var command = data[0];
                var postName = data[1];
                comment.Clear();

                if (command.Equals("post"))
                {
                    if (!postLike.ContainsKey(postName))
                    {
                        postLike[postName] = 0;
                    }
                    if (!postDislike.ContainsKey(postName))
                    {
                        postDislike[postName] = 0;
                    }
                    if (!commentDict.ContainsKey(postName))
                    {
                        commentDict[postName] = new Dictionary<string, string>();
                    }

                }
                else if (command.Equals("like"))
                {
                    postLike[postName]++;
                }
                else if (command.Equals("dislike"))
                {
                    postDislike[postName]++;
                }
                else if (command.Equals("comment"))
                {
                    var commentatorName = data[2];
                    for (int i = 3; i < data.Length; i++)
                    {
                        comment.Add(data[i]);
                    }

                    if (!commentDict.ContainsKey(postName))
                    {
                        commentDict[postName] = new Dictionary<string, string>();
                    }
                    commentDict[postName][commentatorName] = string.Join(" ", comment);
                }

                commandLine = Console.ReadLine();
            }

            foreach (var namePost in commentDict)
            {
                Console.WriteLine($"Post: {namePost.Key} | Likes: {postLike[namePost.Key]} | Dislikes: {postDislike[namePost.Key]}");
                if (namePost.Value.Count == 0)
                {
                    Console.WriteLine("Comments:");
                    Console.WriteLine("None");
                }
                else
                {
                    Console.WriteLine("Comments:");
                    foreach (var post in namePost.Value)
                    {
                        Console.WriteLine($"*  {post.Key}: {string.Join(" ", post.Value)}");
                    }
                }
            }
        }
    }
}
