Random random = new Random();
Menu();

void Menu() //Меню выбора задачи.
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи.");
        Console.WriteLine("Введите цифру для выбора задачи:");
        Console.WriteLine("1 - Программа для вывода количества чётных чисел в массиве.");
        Console.WriteLine("2 - Программа для посчета суммы элементов массива, стоящих на нечётных позициях.");
        Console.WriteLine("3 - Программа для расчета разницы между максимальным и минимальным элементов массива.");
        Console.WriteLine("0 - Для выхода из программы.");
        
        bool access = int.TryParse(Console.ReadLine(),out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                Task_34();
                break;

                case 2:
                Task_36();
                break;

                case 3:
                Task_38();
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

int [] CreateAndFillingArray(int minDimension, int maxDimension, int minValue, int maxValue) //Метод для создания и заполнения массива псевдо-рандомными числами.
{                                                                                            //minDimension - минимальное число размерности массива для метода Random.Next
    int [] arr = new int [random.Next(minDimension, maxDimension)];                          //maxDimension - максимальное число размерности массива для метода Random.Next
                                                                                             //minValue - минимальное значение элемента массива метода Random.Next
    for (int i = 0; i < arr.Length; i++)                                                     //maxValue - максимальное значение элемента массива  метода Random.Next
    {
        arr [i] = random.Next(minValue,maxValue);
    }
    return arr;
}

/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/