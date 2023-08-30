string WelcomeMessage = @"

██████╗░██╗░░░░░░█████╗░██╗░░░██╗  ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔══██╗██║░░░░░██╔══██╗╚██╗░██╔╝  ████╗░████║██║░░░██║██╔════╝██║██╔══██╗
██████╔╝██║░░░░░███████║░╚████╔╝░  ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██╔═══╝░██║░░░░░██╔══██║░░╚██╔╝░░  ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
██║░░░░░███████╗██║░░██║░░░██║░░░  ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═╝░░░░░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░" + "\n \nWelcome to Play Music!";

void ShowWelcomeMessage()
{
    Console.WriteLine(WelcomeMessage);
   
}

ShowWelcomeMessage();

void ShowMenuOptions()
{
    Console.WriteLine("\nEnter 1 to register a new Band: ");
    Console.WriteLine("Enter 2 to show all our Band");
    Console.WriteLine("Enter 3 to rate our Band");
    Console.WriteLine("Enter 4 to show an average Band");
    Console.WriteLine("Enter -1 to exit");

    Console.Write("Enter your option: ");
    string ChosenOption = Console.ReadLine()!;

    if(ChosenOption == "1")
    {
        Console.WriteLine("You choice were Option 1");
    }
}

ShowMenuOptions();