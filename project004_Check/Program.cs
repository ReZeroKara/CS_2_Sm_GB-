//Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Main();

void Main()
{
    bool isWorking = true;

    while(isWorking)
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

    int resultSeven = first % 7;
    int resultTwentyThree = first % 23;

    Console.WriteLine("Деление с остатком на 7 = " + resultSeven);
    Console.WriteLine("Деление с остатком на 23 = " + resultTwentyThree);

    if (resultSeven == 0 & resultTwentyThree == 0)
    {
        Console.WriteLine("Число " + first + " кратно числам 7 и 23 одновременно!");
    }
    else if (resultSeven == 0 & resultTwentyThree != 0)
    {
        Console.WriteLine("Число " + first + " кратно числу 7, но не кратно числу 23!");
    }
    else if (resultSeven != 0 & resultTwentyThree == 0)
    {
        Console.WriteLine("Число " + first + " не кратно числу 7, но кратно числу 23!");
    }
    else if (resultSeven != 0 & resultTwentyThree != 0)
    {
        Console.WriteLine("Число " + first + " не кратно ни числу 7, ни числу 23!");
    }
    else
    {
        Console.WriteLine("Неправельный ввод!");
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