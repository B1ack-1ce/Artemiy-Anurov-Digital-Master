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
        Console.WriteLine("1 - Программа для вывода всех натуральных чисел в промежутке от N до 1.");
        Console.WriteLine("2 - Программа для поиска сумму натуральных элементов в промежутке от N до M .");
        Console.WriteLine("3 - Программа вычисления функции Аккермана.");
        Console.WriteLine("0 - Для выхода из программы.");

        bool access = int.TryParse(Console.ReadLine(), out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                    Console.Clear();
                    Task_64();
                    break;

                case 2:
                    Console.Clear();
                    Task_66();
                    break;

                case 3:
                    Console.Clear();
                    Task_68();
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

int Prompt(string message)
{
    Console.WriteLine(message);
    int userNum = int.Parse(Console.ReadLine());
    return userNum;
}

void Task_64()
{
    Console.WriteLine("Результат: " + FindAllEllementsTo0(Prompt("Введите число N:")));
    Console.ReadLine();
}

string FindAllEllementsTo0(int userNum)
{
    if (userNum == 1) return userNum + " ";
    return userNum + " " + FindAllEllementsTo0(userNum - 1);
}

void Task_66()
{
    int n = Prompt("Введите число N:");
    int m = Prompt("Введите число M:");
    int sum = FindSumAllElements(n, m);
    Console.WriteLine($"Сумма чисел от {n} до {m} = {sum}.");
    Console.ReadLine();
}

int FindSumAllElements(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    return firstNum + FindSumAllElements(firstNum + 1, secondNum);
}

void Task_68()
{
    int sum = AckermannFunction(Prompt("Введите число M:"), Prompt("Введите число N:"));
    Console.WriteLine($"Результат вычисления функции Аккермана: {sum}");
    Console.ReadLine();
}

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}