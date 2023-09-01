class Album
{
    private List<Music> musicList = new List<Music>();
    public string Name { get; set;}

    public int TotalDuration { get; set;} //count the album total duration hour

    public void AddMusic (Music music)
    {
        musicList.Add (music); //added music in the album list
    }
}