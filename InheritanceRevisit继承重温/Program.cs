using InheritanceRevisit继承重温.Models;

Song newSong = new Song
{
    Id = 1,
    Title = "Singing in the Rain",
    Runtime = 400
};


Video newVideo = new Video
{
    Title = "Snowpiercer",
    Runtime = 60000
};

Customer Zach = new Customer
{
    Email = "zmontreuil@mitt.ca",
    Name = "Zach",
    Id = 4,
    Media = new List<IMedia>
    {
        newVideo,newSong
    }
};

Zach.Bing();