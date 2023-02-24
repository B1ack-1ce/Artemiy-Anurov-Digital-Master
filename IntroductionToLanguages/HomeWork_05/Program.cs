Menu();

static void Menu() //Меню выбора задачи
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

static void Task_34()
{
    Random random = new Random();

    int [] arr = new int [random.Next(5,16)];
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100,1000);
    }

    int count = FindEvenNumbersOfArray(arr);

    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine($"Количество положительных элементов в массиве: {count}");
    Console.ReadLine();
}

static int FindEvenNumbersOfArray(int [] arr) //Поиск четных элементов в переданном массиве и их посчет 
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

static void Task_36()
{

}

static void Task_38()
{

}


/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2

Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/