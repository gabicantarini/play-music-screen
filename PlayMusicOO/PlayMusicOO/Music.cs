class Music
{
   public string name;
   public string artistName;
   public int duration;
   public bool available;

    void ShowTechnicalFile()
    {
        Console.WriteLine($"Name: {name}.");
        Console.WriteLine($"Artist: {artistName}.");
        Console.WriteLine($"Duration: {duration}.");
        if (available) {
            Console.WriteLine("Its Available!!");
        } else 
        {
            Console.WriteLine("Its not Available. Please buy PLAN PLUS++"); 
        }
    }


}


