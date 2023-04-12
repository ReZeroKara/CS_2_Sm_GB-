//Программа принимает на вход два числа и проверяет, является ли одно число квадратом второго.

Main();

void Main()
{
    bool isWorking = true;

    while (isWorking)
    {
        Console.Write("Input task: ");
        string task = Console.ReadLine();

        switch(task)
        {
            case "t1": Task1(); break;
            case "exit": isWorking = false; break;
            default:
            break;
        }
    }
}

void Task1()
{
    int first = Readint("a");
    int second = Readint("b");

    double result1 = Math.Pow(first, 2);
    double result2 = Math.Pow(second, 2);

    if (result1 == second)
    {
        Console.WriteLine("Число " + second + " является квадратом числа " + first);
    }
    else if (result2 == first)
    {
        Console.WriteLine("Число " + first + " является квадратом числа " + second);
    }
    else
    {
        Console.WriteLine("Ни одно из чисел не является квадратом второго");
    }
}

int Readint(string argument)
{
    int number;

    Console.Write($"Input {argument}:");

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}