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
        Console.WriteLine("1 - Программа для .");
        Console.WriteLine("2 - Программа для .");
        Console.WriteLine("3 - Программа для .");
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
    Console.WriteLine(FindAllEllementsTo0(Prompt("Введите число:")));
    Console.ReadLine();
}

string FindAllEllementsTo0(int userNum)
{
    if (userNum == 1) return userNum + " ";
    return userNum + " " + FindAllEllementsTo0(userNum - 1);
}

void Task_66()
{
    Console.WriteLine(FindSumAllElements(Prompt("Введите первое число"), Prompt("Введите последнее число")));
    Console.ReadLine();
}

int FindSumAllElements(int firstNum, int secondNum)
{
    if (firstNum == secondNum) return firstNum;
    return firstNum + FindSumAllElements(firstNum + 1, secondNum);
}

void Task_68()
{
    Console.WriteLine(AckermannFunction(2, 3));
    Console.ReadLine();
}

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
    return AckermannFunction(numberM, numberN);
}

/*
Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29
*/