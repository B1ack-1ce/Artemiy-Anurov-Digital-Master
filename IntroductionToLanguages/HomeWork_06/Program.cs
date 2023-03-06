using System;

Menu();

void Menu() //Меню выбора задачи.
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи.");
        Console.WriteLine("Введите цифру для выбора задачи:");
        Console.WriteLine("1 - Программа для подсчета чисел больше 0.");
        Console.WriteLine("2 - Программа для нахождения точки пересечения двух прямых.");
        Console.WriteLine("0 - Для выхода из программы.");

        bool access = int.TryParse(Console.ReadLine(), out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                    Console.Clear();
                    Task_41();
                    break;

                case 2:
                    Console.Clear();
                    Task_43();
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

static int PromptInt(string message) //Метод для упрощения ввода целого числа с консоли
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static double PromptDouble(string message) //Метод для упрощения ввода числа с плавающей запятой с консоли
{
    Console.WriteLine(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

void PrintArray(int[] array)// Вывод массива.
{
    Console.WriteLine(String.Join(" ", array));
}

void Task_41()
{
    int[] nums = new int[PromptInt("Укажите количество чисел.")];
    int positivCount = 0;

    Console.Clear();
    for (int i = 0; i < nums.Length; i++)
    {
        nums[i] = PromptInt($"Введите {i + 1} число.");
        if (nums[i] > 0) positivCount++;
    }

    Console.WriteLine($"Количество чисел больше нуля: {positivCount}");
    Console.ReadLine();
}

void Task_43()
{
    double b1 = PromptDouble("Введите b1:");
    double k1 = PromptDouble("Введите k1:");
    double b2 = PromptDouble("Введите b2:");
    double k2 = PromptDouble("Введите k2:");

    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Точка пересечения двух прямых: ({x}; {y}).");
    Console.ReadLine();
}