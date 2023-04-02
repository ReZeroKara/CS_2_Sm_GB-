//Программа выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа

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
            case "exit": isWorking = false; break;
            case "t1": Task1(); break;
            default:
            break;
        }
    }
}

void Task1()
{
    int first = fint("a");
    int second = sint("b");
    int max = first;
    Console.WriteLine(first);
    Console.WriteLine(second);

    if(IsMoreThen(first, second))
    {
        max = second;
    }
    Console.WriteLine(max);
}

int sint(string numb)
{
    int charm1 = Readint("n");
    charm1 = charm1 % 10;
    return charm1;
}

int fint(string num)
{
    int charm = Readint("n");
    charm = charm / 10;
    return charm;
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

bool IsMoreThen(int first, int second)
{
    return first > second;
}