// // Social Network
using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public string Name;
    public int Age;
    public List<User> Friends = new List<User>();
    public List<Post> Posts = new List<Post>();

    public User(string name, int age)
    {
        Name = name; Age = age;
    }

    public void AddFriend(User u)
    {
        if (u == this) return;
        if (!Friends.Contains(u))
        {
            Friends.Add(u);
            Console.WriteLine($"{Name} added {u.Name}");
        }
    }

    public void RemoveFriend(User u)
    {
        Friends.Remove(u);
    }

    public void ShowFeed()
    {
        var feed = new List<Post>();
        foreach (var f in Friends) feed.AddRange(f.Posts);

        feed = feed.OrderByDescending(p => p.Time).ToList();

        Console.WriteLine($"\n--- {Name}'s Feed ---");
        foreach (var p in feed)
        {
            Console.WriteLine($"{p.Author.Name}: \"{p.Content}\" (Likes: {p.Likes.Count})");
            foreach (var c in p.Comments)
            {
                Console.WriteLine($"  {c.Author.Name}: \"{c.Content}\" (Likes: {c.Likes.Count})");
            }
        }
        Console.WriteLine();
    }
}

class Post
{
    public User Author;
    public string Content;
    public List<Comment> Comments = new List<Comment>();
    public List<User> Likes = new List<User>();
    public DateTime Time = DateTime.Now;

    public Post(User a, string c)
    {
        Author = a; Content = c;
    }

    public void AddComment(Comment c)
    {
        Comments.Add(c);
    }

    public void AddLike(User u)
    {
        if (!Likes.Contains(u)) Likes.Add(u);
    }
}

class Comment
{
    public User Author;
    public string Content;
    public List<User> Likes = new List<User>();

    public Comment(User a, string c)
    {
        Author = a; Content = c;
    }

    public void AddLike(User u)
    {
        if (!Likes.Contains(u)) Likes.Add(u);
    }
}

class Program
{
    static void Main()
    {
        var alice = new User("Alice", 25);
        var bob = new User("Bob", 30);
        var carol = new User("Carol", 22);

        alice.AddFriend(bob);
        bob.AddFriend(carol);

        var p1 = new Post(alice, "Hello world!");
        alice.Posts.Add(p1);

        var c1 = new Comment(bob, "Nice post!");
        p1.AddComment(c1);

        p1.AddLike(bob);
        c1.AddLike(carol);

        bob.ShowFeed();
    }
}