Console.WriteLine("Welcome to my Calculator! My name is Mateo and im from Argentina.");

// Start Menu
static void Menu()
{
    int Input;
    int Input2;
    bool IsTrue;
    string? option;
    Console.WriteLine("Please, select a option.");
    Console.WriteLine("1. Sum");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Division");
    Console.WriteLine("4. Multiplication");
    option = Console.ReadLine();
    if (option == "1")
    {
        do
        {
            Console.WriteLine("Please, select the first number.");
            IsTrue = int.TryParse(Console.ReadLine(), out Input);
        }
        while (!IsTrue);

        do
        {
            Console.WriteLine("Please, select the second number.");
            IsTrue = int.TryParse(Console.ReadLine(), out Input2);
        }
        while (!IsTrue);

        Console.WriteLine($"The result is {Operations.Sum(Input, Input2)}");
        Fin();
    }
    else if (option == "2")
    {

    }
    else if (option == "3")
    {

    }
    else if (option == "4")
    {

    }
    else
    {
        Console.WriteLine("Please, select a option");
        Console.Clear();
        Menu();
    }

}

static void Fin()
{
    string? option = string.Empty;
    Console.WriteLine("Do you want continue?");
    Console.WriteLine("Yes (Y) , No (N)");
    option = Console.ReadLine();
    if (option is not null)
    {
        if (option.ToUpper() == "Y")
        {
            Console.Clear();
            Menu();
        }
        else if (option.ToUpper() == "N")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Try Again");
            Console.Clear();
            Fin();
        }
    }

}

Menu();