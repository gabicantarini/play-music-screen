class Band
{
    private List<Album> albums = new List<Album>();
    public string Name { get; set; }

    public void AddAlbum(Album album)
    {
        albums.Add(album);
    }


}