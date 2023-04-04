// Программа, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа, а затем выводит двухзначное.

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
    int number = GetRandom(100);
    int first = number / 100;
    int second = number % 10;
    

    Console.WriteLine("Число: " + number);
    Console.WriteLine("Получившееся число: " + first + second);
}

int GetRandom (int num)
{
    return new Random().Next(100, 999);
}