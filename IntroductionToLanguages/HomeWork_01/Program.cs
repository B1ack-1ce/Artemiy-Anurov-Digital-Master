
Menu();

static void Menu() // Меню вызова задач.
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи:");
        Console.WriteLine("Нажмите цифру для выбора задачи");
        Console.WriteLine("1 - Программа для поиска максимального числа из двух заданных чисел.");
        Console.WriteLine("2 - Программа для поиска максимального числа из трех заданных чисел.");
        Console.WriteLine("3 - Программа для проверки четности числа.");
        Console.WriteLine("4 - Программа для поиска всех четных чисел в диапазоне от 1 до заданного числа.");
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

                case 4:
                Example_04();
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

static void Example_01()
{
    Console.Clear();
    Console.WriteLine("Программа для поиска максимального числа из двух заданных чисел.");
    Console.WriteLine("Введите первое число");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber > secondNumber)
    {
        System.Console.WriteLine($"Первое число {firstNumber} больше второго числа {secondNumber}");
        Console.ReadLine();    
    }
    else if (secondNumber > firstNumber)
    {
        System.Console.WriteLine($"Второе число {secondNumber} больше первого числа {firstNumber}");
        Console.ReadKey();
    }
    else
    {
        System.Console.WriteLine("Числа равны");
        Console.ReadLine();
    }
}

static void Example_02()
{
    Console.Clear();
    Console.WriteLine("Программа для поиска максимального числа из трех заданных чисел.");
    Console.WriteLine("Введите первое число");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int thirdNumber = Convert.ToInt32(Console.ReadLine());

    int [] arr = {firstNumber, secondNumber, thirdNumber};
    int max = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr [i];
        }
    }

    System.Console.WriteLine($"Максимальное число из трех введенных = {max}.");
    Console.ReadLine();
}

static void Example_03()
{
    Console.Clear();
    Console.WriteLine("Программа для проверки числа на четность.");
    Console.WriteLine("Введите число.");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    if (userNumber % 2 == 0)
    {
        System.Console.WriteLine($"Число {userNumber} является четным.");
        Console.ReadLine();
    }
    else
    {
        System.Console.WriteLine($"Число {userNumber} является нечетным.");
        Console.ReadLine();
    }
}

static void Example_04()
{
    Console.Clear();
    Console.WriteLine("Программа для поиска всех четных чисел в диапазоне от 1 до заданного числа.");
    Console.WriteLine("Введите число.");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= userNumber; i++)
    {
        if (i % 2 == 0)
        {
            System.Console.Write($"{i}\t");
        }
    }
    Console.ReadLine();
}