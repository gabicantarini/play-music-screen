class Album
{
    private List<Music> musicList = new List<Music>();
    public string Name { get; set;}

    public int TotalDuration => musicList.Sum(m => m.Duration); //sum each music total the album total duration hour

    public void AddMusic (Music music)
    {
        musicList.Add (music); //added music in the album list
    }

    public void ShowMusicOnAlbum()
    {
        Console.WriteLine($"Album {Name} music list.");

        foreach (Music music in musicList)
        {
            Console.WriteLine($"Music: {music.Name}");
        }

        Console.WriteLine($"\nThis Album contain {TotalDuration} total duration.");
    }
}