

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
            //Example_01();
            break;

            case 2:
            //Example_02();
            break;

            case 3:
            //Example_03();
            break;

            case 4:
            //Example_04();
            break;

            case 0:
            flag = true;
            break;

            default:
            Console.Clear();
            Console.WriteLine("switch Команда не распознана. Повторите попытку.");
            Console.ReadLine();
            break;
        }
    }
    else 
    {
        Console.Clear();
        Console.WriteLine("else Команда не распознана. Повторите попытку");
        Console.ReadLine();
    }
}

/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/
