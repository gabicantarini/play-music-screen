class Chapter
{
    private List<string> newGuest = new();
      
    public Chapter(int number, string title)
    {
        Number = number;
        Title = title;
    }

    public int Number { get; }
    public string Title { get; set; }
    public int Duration { get; set; }
    public string Summary => $"The today´s chapter is number {Number}, {Title} and duration {Duration}.";

    public void AddGuest(string guest)
    {
        newGuest.Add(guest); //added music in the album list
    }

}