using System;

Random rnd = new Random();

Menu();

void Menu() //Меню выбора задачи.
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи.");
        Console.WriteLine("Введите цифру для выбора задачи:");
        Console.WriteLine("1 - Программа для вывода массива вещественных чисел.");
        Console.WriteLine("2 - Программа для вывода значения элемента массива по введенному индексу.");
        Console.WriteLine("3 - Программа для поиска заданного значения в массиве.");
        Console.WriteLine("4 - Программа для расчета среднего арифметическое каждого столбца.");
        Console.WriteLine("0 - Для выхода из программы.");

        bool access = int.TryParse(Console.ReadLine(), out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                    Console.Clear();
                    Task_47();
                    break;

                case 2:
                    Console.Clear();
                    Task_50_01();
                    break;

                case 3:
                    Console.Clear();
                    Task_50_02();
                    break;

                case 4:
                    Console.Clear();
                    Task_52();
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
    int userNum = Convert.ToInt32(Console.ReadLine());
    return userNum;
}

int[,] FillArray(int firstDim, int secondDim) //Создание и заполнение целочисленного массива.
{
    int[,] arr = new int[firstDim, secondDim];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 11);
        }
    }
    return arr;
}

double[,] FillDoubleArray(int firstDim, int secondDim) //Создание и заполнения вещественного массива.
{
    double[,] arr = new double[firstDim, secondDim];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(10, 100) * rnd.NextDouble();
        }
    }
    return arr;
}

void ShowArray(int[,] arr)
{
    Console.WriteLine("Сгенерированный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"|{arr[i, j]}|\t");
        }
        Console.WriteLine();
    }
}

void ShowDoubleArray(double[,] arr)
{
    Console.WriteLine("Массив вещественных чисел:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"|{arr[i, j]:f1}|\t");
        }
        Console.WriteLine();
    }
}

void Task_47()
{
    double[,] userArr = FillDoubleArray(
                        Prompt("Введите количество строк"),
                        Prompt("Введите количество столбцов"));
    ShowDoubleArray(userArr);
    Console.ReadLine();
}

void Task_50_01()
{
    int[,] userArr = FillArray(
                     Prompt("Введите первую размерность"), 
                     Prompt("Введите вторую размерность"));
    ShowArray(userArr);
    ShowValueElement(userArr, Prompt("Введите позицию элемента массива"));
    Console.ReadLine();
}

void ShowValueElement(int[,] userArr, int pos)
{
    int[] oneArr = new int[userArr.GetLength(0) * userArr.GetLength(1)];

    int count = 0;
    int index = 0;

    for (int i = 0; i < userArr.GetLength(0); i++)
    {
        for (int j = 0; j < userArr.GetLength(1); j++)
        {
            oneArr[index] = userArr[i, j]; //Здесь мы копируем значения из двумерного в одномерный массив

            if (pos == index)
                Console.WriteLine($"Значение элемента под индексом {pos}: {oneArr[index]}");
            else count++;

            index++;
        }
    }
    if (count == oneArr.Length)
        Console.WriteLine("Такой позиции в массиве не сущесвует.");
}

void Task_50_02()
{
    int[,] userArr = FillArray(Prompt("Введите первую размерность"), Prompt("Введите вторую размерность"));
    ShowArray(userArr);
    FindElementInArray(userArr, Prompt("Какое число хотите найти?"));
    Console.ReadLine();
}

void FindElementInArray(int[,] userArr, int value)
{
    int count = 0;

    for (int i = 0; i < userArr.GetLength(0); i++)
    {
        for (int j = 0; j < userArr.GetLength(1); j++)
        {
            if (userArr[i, j] == value)
                Console.WriteLine($"Элемент массива со значением {value} существует на позиции {i}, {j}");
            else count++;
        }
    }
    if (userArr.GetLength(0) * userArr.GetLength(1) == count)
        Console.WriteLine($"Элемент {value} не найден.");
}

void Task_52()
{
    int[,] userArr = FillArray(rnd.Next(2, 6), rnd.Next(2, 6));
    ShowArray(userArr);
    ShowAverageValue(userArr);
    Console.ReadLine();

}

void ShowAverageValue(int[,] arr)
{
    double[] avgArr = new double[arr.GetLength(1)];
    double sum = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        avgArr[j] = sum / arr.GetLength(0);
        sum = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"Среднее арифметическое каждого столбца:");
    foreach (var item in avgArr)
    {
        Console.Write($"{item:f2}  ");
    }
}