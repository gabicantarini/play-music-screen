class Podcast
{
    private List<Chapter> chapters = new();
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public int TotalChapter => chapters.Count;


    public void ShowDetails()
    {
        Console.WriteLine($"Podcast {Name}, hosted by {Host}.");
        foreach (Chapter chapter in chapters)
        {
            Console.WriteLine(chapter.Summary);
        }
        Console.WriteLine($"Total chapter: {TotalChapter}");
    }

    public void AddChapter(Chapter newChapter)
    {

        chapters.Add(newChapter);
    }



}



