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
    int NumericChoice = int.Parse(ChosenOption);

    switch (NumericChoice)
    {
        case 1: Console.WriteLine("Chosen option " + NumericChoice);
            break; 

        case 2: Console.WriteLine("Chosen option " + NumericChoice);
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

ShowMenuOptions();
