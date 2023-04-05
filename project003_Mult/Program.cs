// Программа принимает на вход два числа и узнаёт, является ли первое число кратным второму

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
    int first = fint();
    int second = sint();

    Console.WriteLine("Первое число: " + first);
    Console.WriteLine("Второе число: " + second);

    int result = first % second;
    
    if(result == 0)
    {
        Console.WriteLine("Число: " + first + " кратно числу: " + second);
    }
    else if(result > 0)
    {
        Console.WriteLine("Число: " + first + " не кратно числу: " + second + ". Остаток: " + result);
    }
    else
    {
        Console.WriteLine("Ошибка программы, попробуйте заново!");
    }
}

int fint()
{
    Console.Write("Введите первое число: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int sint()
{
    Console.Write("Введите второе число: ");
    int num2 = int.Parse(Console.ReadLine());
    return num2;
}
