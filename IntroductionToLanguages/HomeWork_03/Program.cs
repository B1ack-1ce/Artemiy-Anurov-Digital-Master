using System;

Menu();

static void Menu() //Меню выбора задачи
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи.");
        Console.WriteLine("Введите цифру для выбора задачи:");
        Console.WriteLine("1 - Программа для проверки пятизначного числа на палиндром.");
        Console.WriteLine("2 - Программа для рассчета расстояния между двумя точками в 3D пространстве.");
        Console.WriteLine("3 - Программа для вывода таблицы кубов от 1 до N числа.");
        Console.WriteLine("0 - Для выхода из программы.");
        
        bool access = int.TryParse(Console.ReadLine(),out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                Task_01();
                break;

                case 2:
                Task_02();
                break;

                case 3:
                Task_03();
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
            Console.WriteLine("Ошибка ввода. Повторите попытку.");
            Console.ReadLine();
        }
    }
}

static int Prompt(string message) //Метод для упрощения ввода числа с консоли
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task_01() //Первая задача
{
    Console.Clear();
    Console.WriteLine("Программа для проверки пятизначного числа на палиндром. ");
    int userNumber = Prompt("Введите  число.");

    if (userNumber < 0)
    {
        userNumber = Math.Abs(userNumber);
    }

    int secondNumber = userNumber / 1000 % 10;
    int fourthNumber = userNumber / 10 % 10;

    if (userNumber >= 10000 && userNumber < 100000)
    {
        if ((userNumber / 10000 == userNumber % 10) && (secondNumber == fourthNumber))
        {
            Console.WriteLine($"Число является палиндромом");
        }   
        else
        {
           Console.WriteLine($"Число не является палиндромом"); 
        } 
    }
    else
    {
        Console.WriteLine("Число не является пятизначным");
    }
    Console.ReadLine();
}

static void Task_02() //Вторая задача
{
    Console.Clear();
    Console.WriteLine("");
    int [] firstPoint = new int [3];
    int [] secondPoint = new int [3];

    for (int i = 0; i < firstPoint.Length; i++)
    {
        firstPoint[i] = Prompt($"Введите {i + 1}  координату первой точки.");
    }

    for (int i = 0; i < secondPoint.Length; i++)
    {
        secondPoint[i] = Prompt($"Введите {i +1} координату второй точки");
    }

    double distance = Math.Sqrt(Math.Pow(secondPoint[0] - firstPoint[0], 2) + Math.Pow(secondPoint[1] - firstPoint[1], 2) + Math.Pow(secondPoint[2] - firstPoint[2], 2));

    Console.WriteLine($"Расстояние между двумя точками в 3D пространстве: {distance:f2}");
    Console.ReadLine();
}

static void Task_03() //Третья задача
{
    Console.Clear();
    int userNumber = Prompt("Введите число больше 0.");

    for (int i = 1; i <= userNumber; i++)
    {
        Console.Write($"{i * i * i}\t");
    }
    Console.ReadLine();
}