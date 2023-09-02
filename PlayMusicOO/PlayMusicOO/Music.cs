class Music
{
    public Music(Band artistName, string name)
    {
        ArtistName = artistName;
        Name = name;
    }

    public string Name { get; }
    public Band ArtistName { get; }
    public int Duration { get; set; }
    public bool Available { get; set; } // property write(set)  and read(get) operation

    public string Summary => $"The music {Name} is from the {ArtistName} band."; // Lambda: is the arrow function in C# 
    public void ShowTechnicalFile()
    {
        Console.WriteLine($"Name: {Name}.");
        Console.WriteLine($"Artist: {ArtistName}.");
        Console.WriteLine($"Duration: {Duration}.");
        if (Available) {
            Console.WriteLine("Its Available!!");
        } else
        {
            Console.WriteLine("Its not Available. Please buy PLAN PLUS++");
        }
    }

}


