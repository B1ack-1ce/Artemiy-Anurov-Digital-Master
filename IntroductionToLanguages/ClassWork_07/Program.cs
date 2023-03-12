using System;

Menu();

void Menu() // Меню выбора задач.
{
    Console.Clear();
    Console.WriteLine("1 - Программа для ");
    Console.WriteLine("2 - Программа для возведение значения элемента в квадрат, стоящего на четных индексах.");
    Console.WriteLine("3 - Программа для поиска суммы элементов, находящихся на главной диагонали.");
    int numberOfTask = Prompt("Введите номер задачи");
    switch (numberOfTask)
    {
        case 1:
            Console.Clear();
            Task_48();
            break;

        case 2:
            Console.Clear();
            Task_49();
            break;

        case 3:
            Console.Clear();
            Task_51();
            break;

        default:
            Console.WriteLine("Номер задачи введен некорректно.");
            break;
    }
}


static int Prompt(string message) //Метод для упрощения ввода числа с консоли
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] FillArray(int firstDimension, int secondDimension) // Заполнение двумерного массива с заданной размерностью.
{
    int[,] arr = new int[firstDimension, secondDimension];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
    return arr;
}

void ShowArray(int[,] arr) // Вывод массива на экран.
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
    }
}

void Task_48()
{
    Console.Clear();
    int firstDimension = Prompt("Введите первую размерность");
    int secondDimension = Prompt("Введите вторую размерность");

    int[,] arr = new int[firstDimension, secondDimension];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
            Console.Write(arr[i, j] + " ");
        }
    }
}

void Task_49()
{
    Console.Clear();
    int firstDimension = Prompt("Введите первую размерность");
    int secondDimension = Prompt("Введите вторую размерность");

    int[,] arr = FillArray(firstDimension, secondDimension);

    ShowArray(arr);

    arr = PowEvenElements(arr);

    ShowArray(arr);

    Console.ReadLine();
}

int[,] PowEvenElements(int[,] arr) // Возведение значения элемента в квадрат, стоящего на четных индексах.
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
        }
    }
    return arr;
}

void Task_51()
{
    Console.Clear();
    int firstDimension = Prompt("Введите первую размерность");
    int secondDimension = Prompt("Введите вторую размерность");

    int[,] arr = FillArray(firstDimension, secondDimension);

    ShowArray(arr);

    int sumEvenElements = FindSumEvenElements(arr);

    Console.WriteLine();
    Console.WriteLine($"Сумма элементов на главной диагонали: {sumEvenElements}.");
    Console.ReadLine();
}

int FindSumEvenElements(int[,] arr) // Поиск суммы элементов, находящихся на главной диагонали. Относится к задаче Task_51.
{
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j) sum += arr[i, j];
        }
    }
    return sum;
}