string WelcomeMessage = @"

██████╗░██╗░░░░░░█████╗░██╗░░░██╗  ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔══██╗██║░░░░░██╔══██╗╚██╗░██╔╝  ████╗░████║██║░░░██║██╔════╝██║██╔══██╗
██████╔╝██║░░░░░███████║░╚████╔╝░  ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██╔═══╝░██║░░░░░██╔══██║░░╚██╔╝░░  ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
██║░░░░░███████╗██║░░██║░░░██║░░░  ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═╝░░░░░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░" + "\n \nWelcome to Play Music!";

List<string> BandListName = new List<string>();

void ShowWelcomeMessage()
{
    Console.WriteLine(WelcomeMessage);
   
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
    string ChosenOption = Console.ReadLine()!;
    int NumericChoice = int.Parse(ChosenOption);

    switch (NumericChoice)
    {
        case 1: RegisterNewBand();
            break; 

        case 2: BandList();
            break;

        case 3: Console.WriteLine("Chosen option " + NumericChoice);
            break;

        case 4: Console.WriteLine("Chosen option " + NumericChoice);
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
    Console.Write("Enter Band name: ");
    string BandName = Console.ReadLine()!;
    BandListName.Add(BandName);
    Console.WriteLine($"{BandName} Band was successful registered");
    Thread.Sleep(1500);
    Console.Clear();
    ShowMenuOptions();

}


void BandList()
{
    Console.Clear();
    Console.Write("Band List: \n");
    for (int i = 0; i < BandListName.Count; i++)
    {
        Console.WriteLine($"Band: {BandListName[i]}");
    };
    Console.WriteLine("Enter any digit to show MENU OPTIONS");
    Console.ReadKey();
    ShowMenuOptions();

}


ShowMenuOptions();
