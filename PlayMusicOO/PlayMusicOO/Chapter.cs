class Chapter
{
    private List<string> guest = new();
      
    public Chapter(int number, string title)
    {
        Number = number;
        Title = title;
    }

    public int Number { get; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public string Summary => $"The today´s chapter is number: {Number}, title: {Title}, duration: {Duration}, guest: {string.Join(" , ", guest)}.";

    public void AddGuest(string newGuest)
    {
        guest.Add(newGuest); //added music in the album list
    }

}