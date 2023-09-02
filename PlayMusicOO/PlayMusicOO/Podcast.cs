class Podcast
{
    public Podcast(string name, string host)
    {
        Name = name;
        Host = host;
    }

    public string Name { get; }
    public string Host { get; }
    public int TotalChapter { get; set; }

    public void ShowDetails()
    {
        Console.WriteLine($"Poscast name: {Name}, hosted by {Host}.");
    }

}

