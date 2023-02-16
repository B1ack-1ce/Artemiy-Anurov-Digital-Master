Menu();

static void Menu() // Меню вызова задач.
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи:");
        Console.WriteLine("Нажмите цифру для выбора задачи");
        Console.WriteLine("1 - Программа для вывода второй цифры из заданного трехзначного числа.");
        Console.WriteLine("2 - Программа для вывода третьей цифры из заданного числа, если она есть.");
        Console.WriteLine("3 - Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
        Console.WriteLine("0 - для выхода из программы.");
        
        bool access = int.TryParse(Console.ReadLine(),out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                Example_01();
                break;

                case 2:
                Example_02();
                break;

                case 3:
                Example_03();
                break;

                case 0:
                flag = true;
                break;

                default:
                Console.Clear();
                Console.WriteLine("Номер задачи введен некорректно. Повторите попытку.");
                Console.ReadLine();
                break;
            }
        }
        else 
        {
            Console.Clear();
            Console.WriteLine("Команда не распознана. Повторите попытку");
            Console.ReadLine();
        }
    }
}

static int Result(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Example_01()
{
    Console.Clear();
    Console.WriteLine("Программа для вывода второй цифры из заданного трехзначного числа.");
    int userNumber = Result("Введите трехзначное число:");

    if (userNumber >= 100 && userNumber < 1000)
    {
        int secondRank = userNumber / 10 % 10;
        Console.WriteLine($"\nВведенное число: {userNumber}.\nВторая цифра: {secondRank}");
    }
    else
    {
        Console.WriteLine("Число не является трехзначным.");
    }
    Console.ReadLine();
}

static void Example_02()
{
    Console.Clear();
    Console.WriteLine("Программа для вывода третьей цифры из заданного числа, если она есть.");
    int userNumber = Result($"\nВведите число.");

    Console.WriteLine($"\nВведенное число: {userNumber}.");

    if (userNumber < 0)
    {
        userNumber = System.Math.Abs(userNumber);
    }

    if (userNumber >= 100) // 
    {
        while (userNumber >= 1000)
        {
            userNumber /= 10;
        }
        int thirdRank = userNumber % 10;
        Console.WriteLine($"Третья цифра: {thirdRank}.");
    }
    else
    {
        Console.WriteLine($"\nВведенное число имеет меньше 3 цифр.");
    }
    Console.ReadLine();
}

static void Example_03()
{
    Console.Clear();
    Console.WriteLine("Программа для проверки выходного дня");
    int userNumber = Result($"Введите день недели от 1 до 7 (аналогично пн-вс).");

    switch (userNumber)
    {
        case 1:
            goto case 4;

        case 2:
            goto case 4;

        case 3:
            goto case 4;

        case 4:
            System.Console.WriteLine("Сегодня рабочий день и не пятница :-(");
            break;
        case 5:
            System.Console.WriteLine("Сегодня пятница! :-)\t... но не выходной");
            break;

        case 6:
            System.Console.WriteLine("Суббота - выходной!");
            break;

        case 7:
            System.Console.WriteLine("Воскресенье - последний выходной. :-(");
            break;

        default:
            System.Console.WriteLine("В нашей Галактике нет такого дня, сожалеем.");
            break;
    }
    Console.ReadLine();
}
/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/