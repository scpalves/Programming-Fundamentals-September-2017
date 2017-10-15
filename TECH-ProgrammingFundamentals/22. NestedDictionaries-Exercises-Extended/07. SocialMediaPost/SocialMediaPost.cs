using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static Dictionary<string, int> likeData = new Dictionary<string, int>();
    static Dictionary<string, int> dislikeData = new Dictionary<string, int>();
    static Dictionary<string, Dictionary<string, List<string>>> commentData =
        new Dictionary<string, Dictionary<string, List<string>>>();
    static void Main()
    {
        var input = Console.ReadLine();
        while (input != "drop the media")
        {
            var inputTokens = input.Split(' ');
            var cmd = inputTokens[0];
            var post = inputTokens[1];
            switch (cmd)
            {
                case "post":
                    PostData(post);
                    break;
                case "like":
                    LikeData(post);
                    break;
                case "dislike":
                    DislikeData(post);
                    break;
                case "comment":
                    var name = inputTokens[2];
                    var comments = inputTokens.Skip(3).ToList();
                    AddCommentator(post, name, comments);
                    break;
            }
            input = Console.ReadLine();
        }
        PrintPostData();
    }
    static void PostData(string post)
    {
        likeData.Add(post, 0);
        dislikeData.Add(post, 0);
        commentData.Add(post, new Dictionary<string, List<string>>());
    }
    static void LikeData(string post)
    {
        likeData[post]++;
    }
    static void DislikeData(string post)
    {
        dislikeData[post]++;
    }
    static void AddCommentator(string post, string name, List<string> comments)
    {
        if (commentData.ContainsKey(post))
        {
            if (!commentData[post].ContainsKey(name))
            {
                commentData[post].Add(name, new List<string>());
            }
            commentData[post][name].AddRange(comments);
        }
    }
    static void PrintPostData()
    {
        foreach (var info in commentData)
        {
            bool noComment = true;
            var post = info.Key;
            var likes = likeData[post];
            var dislikes = dislikeData[post];
            Console.WriteLine($"Post: {post} | Likes: {likes} | Dislikes: {dislikes}");
            Console.WriteLine("Comments:");
            foreach (var item in info.Value)
            {
                noComment = false;
                Console.WriteLine($"*  {item.Key}: {string.Join(" ", item.Value)}");
            }
            if (noComment)
            {
                Console.WriteLine("None");
            }
        }
    }

}