Console.WriteLine("Welcome to my Calculator! My name is Mateo and im from Argentina.");

// Start Menu
static void Menu()
{
    string? option;
    Console.WriteLine("Please, select a option.");
    Console.WriteLine("1. Sum");
    Console.WriteLine("2. Subtract");
    Console.WriteLine("3. Division");
    Console.WriteLine("4. Multiplication");
    Console.WriteLine("5. Exit");
    option = Console.ReadLine();
    if (option == "1")
    {
        (int n1, int n2) = Operations.AddNum();

        Console.WriteLine($"The result is {Operations.Sum(n1, n2)}");
        Fin();
    }
    else if (option == "2")
    {
        (int n1, int n2) = Operations.AddNum();

        Console.WriteLine($"The result is {Operations.Subtract(n1, n2)}");
        Fin();
    }
    else if (option == "3")
    {
        (int n1, int n2) = Operations.AddNum();

        Console.WriteLine($"The result is {Operations.Division(n1, n2)}");
        Fin();
    }
    else if (option == "4")
    {
        (int n1, int n2) = Operations.AddNum();

        Console.WriteLine($"The result is {Operations.Multiplication(n1, n2)}");
        Fin();
    }
    else if (option == "5")
    {
        Console.Clear();
        Console.WriteLine("Thanks for using my calculator!");
        Environment.Exit(0);
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