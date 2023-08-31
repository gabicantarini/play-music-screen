string welcomeMessage = @"

██████╗░██╗░░░░░░█████╗░██╗░░░██╗  ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔══██╗██║░░░░░██╔══██╗╚██╗░██╔╝  ████╗░████║██║░░░██║██╔════╝██║██╔══██╗
██████╔╝██║░░░░░███████║░╚████╔╝░  ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██╔═══╝░██║░░░░░██╔══██║░░╚██╔╝░░  ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
██║░░░░░███████╗██║░░██║░░░██║░░░  ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═╝░░░░░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░" + "\n \nWelcome to Play Music!";

//List<string> BandListName = new List<string>{"U2", "Cold Play", "Lulu Santos"};

Dictionary<string, List<int>> registeredBands = new Dictionary<string, List<int>>();
registeredBands.Add("U2", new List<int> {8, 10, 6});
registeredBands.Add("Cold Play", new List<int>());


void ShowWelcomeMessage()
{
    Console.WriteLine(welcomeMessage);   
}

void ShowMenuOptions()
{
    ShowWelcomeMessage();
    Console.WriteLine("\nEnter 1 to register a new Band: ");
    Console.WriteLine("Enter 2 to show all our Band");
    Console.WriteLine("Enter 3 to rate our Band");
    Console.WriteLine("Enter 4 to show an average Band");
    Console.WriteLine("Enter -1 to exit");

    Console.Write("Enter your option: ");
    string chosenOption = Console.ReadLine()!;
    int numericChoice = int.Parse(chosenOption);

    switch (numericChoice)
    {
        case 1: RegisterNewBand();
            break; 

        case 2: BandList();
            break;

        case 3: RateBand();
            break;

        case 4: 
            break;

        case -1: Console.WriteLine("BYE BYE :)");
            break;

        default: Console.WriteLine("Invalid Option!");
            break;
    }

}

void RegisterNewBand()
{
    Console.Clear();
    ShowOptionsTitle(" Register New Band ");
    Console.Write("Enter Band name: ");
    string bandName = Console.ReadLine()!;
    registeredBands.Add(bandName, new List<int>());
    Console.WriteLine($"{bandName} Band was successful registered");
    Thread.Sleep(1500);
    Console.Clear();
    ShowMenuOptions();

}

void BandList()
{
    Console.Clear();
    ShowOptionsTitle(" Band List ");
    foreach (string band in registeredBands.Keys)
    { 
        Console.WriteLine($"Band: {band}");
    };
    Console.WriteLine("\nEnter any digit to show MENU OPTIONS");
    Console.ReadKey();
    ShowMenuOptions();
}

void ShowOptionsTitle( string title){
    
    int countTitle = title.Length;
    string asterisks = string.Empty.PadLeft(countTitle, '*');
    Console.WriteLine(asterisks);
    Console.WriteLine(title);
    Console.WriteLine(asterisks + "\n");
}

void RateBand()
{
    Console.Clear();
    ShowOptionsTitle(" Band Rate ");
    Console.Write("Enter band name for rating: ");
    string bandsName = Console.ReadLine()!;
    if (registeredBands.ContainsKey(bandsName))
    {
        Console.Write($"Enter band {bandsName} rate: ");
        string bandsRate = Console.ReadLine()!;
        int numericRate = int.Parse(bandsRate);
        registeredBands[bandsName].Add(numericRate);
        Console.Write($"{bandsName} rate: {numericRate}");
        Console.WriteLine($"\nBand {bandsName} successfully registered!!");
        Thread.Sleep(1000);
        Console.Clear();
        ShowMenuOptions();
    }
    else
    {
        Console.WriteLine($"\nBand {bandsName} NOT FOUND");
        Console.WriteLine("\nEnter any digit to show MENU OPTIONS");
        Console.ReadKey();
        ShowMenuOptions();
    }
}


ShowMenuOptions();
