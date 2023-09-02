class Band
{
    private List<Album> albums = new List<Album>();

    public Band(string name)
    {
        Name = name;
    }
    public string Name { get; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ShowDiscography()
    {
        foreach (Album album in albums)
        {
            Console.WriteLine($"Discography name {album.Name} {album.TotalDuration}.");
        }
    }

}

