using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>{};

        Video cats = new Video("cats", "charles dickens", 30);
        cats.AddComment("susan", "why does his face look like that?");
        cats.AddComment("david", "I miss my cat, she ran away");
        cats.AddComment("Steve", "Click this link for free bitcoin bit.ly/56987");
        _videos.Add(cats);

        Video puppies = new Video("puppies", "leroy jenkins", 60);
        puppies.AddComment("karen", "Stop feeding him dog food, he deserves steaks");
        puppies.AddComment("cesar", "What a cute doggy");
        puppies.AddComment("Elon", "Your dog will be the first in space. Check your dms");
        _videos.Add(puppies);

        Video conspiracy = new Video("Birds are government spies", "anonymous man", 100000);
        conspiracy.AddComment("timmy", "very insightful, I will be hiding from birds now");
        conspiracy.AddComment("eggman", "I am an egg");
        conspiracy.AddComment("fbi", "We are watching your house");
        _videos.Add(conspiracy);

        foreach (Video v in _videos)
        {
            Console.WriteLine();
            v.Display();
            Console.WriteLine();
        }
    }
}