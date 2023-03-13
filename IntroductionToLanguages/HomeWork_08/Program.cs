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
        Console.WriteLine("1 - Программа для сортировки элементов по убыванию в каждой строке.");
        Console.WriteLine("2 - Программа для поиска строки с наименьшей суммой элементов.");
        Console.WriteLine("3 - Программа для произведения двух матриц.");
        Console.WriteLine("4 - Программа для создания трехмерного массива из неповторяющихся двузначных чисел.");
        Console.WriteLine("5 - Программа для заполнения спиралью массив с заданной размерностью.");
        Console.WriteLine("0 - Для выхода из программы.");

        bool access = int.TryParse(Console.ReadLine(), out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                    Console.Clear();
                    Task_54();
                    break;

                case 2:
                    Console.Clear();
                    Task_56();
                    break;

                case 3:
                    Console.Clear();
                    Task_58();
                    break;

                case 4:
                    Console.Clear();
                    Task_60();
                    break;

                case 5:
                    Console.Clear();
                    Task_62();
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
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] FillArray(int firstDim, int secondDim)
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

void ShowArray(int[,] arr, string msg = "")
{
    Console.WriteLine(msg);
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"|{arr[i, j]}|\t");
        }
        Console.WriteLine();
    }
}

void Task_54()
{
    int[,] array = FillArray(Prompt("Введите первую размерность."), Prompt("Введите вторую размерность."));
    ShowArray(array, "Сгенерированный массив:");

    SortArray(array);
    ShowArray(array, "Отсортированный массив:");

    Console.ReadLine();
}
void SortArray(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 1; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    }
}

void Task_56()
{
    int[,] array = FillArray(Prompt("Введите первую размерность."), Prompt("Введите вторую размерность."));
    ShowArray(array, "Сгенерированный массив:");
    FindMinSumInRow(array);
    Console.ReadLine();
}
void FindMinSumInRow(int[,] arr)
{
    int tempSumLine = 0;
    int indexMinSum = 0;

    int sumLine = SumElementsInRow(arr, 0);

    for (int i = 1; i < arr.GetLength(0); i++)
    {
        tempSumLine = SumElementsInRow(arr, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            indexMinSum = i;
        }
    }
    Console.WriteLine($"Минимальную сумму элементов равную {sumLine} имеет строка {indexMinSum + 1}.");
}
int SumElementsInRow(int[,] array, int index)
{
    int sumLine = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumLine += array[index, j];
    }
    return sumLine;
}

void Task_58()
{
    int[,] firstMatrix = FillMatrix();
    int[,] secondMatrix = FillMatrix();

    ShowArray(firstMatrix, "Первая матрица:");
    ShowArray(secondMatrix, "Вторая матрица:");

    MultyTwoMatrix(firstMatrix, secondMatrix);
    Console.ReadLine();
}
int[,] FillMatrix()
{
    int[,] matrix = new int[rnd.Next(2, 4), rnd.Next(2, 4)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 5);
        }
    }
    return matrix;
}
void MultyTwoMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) == secondMatrix.GetLength(0))
    {
        int[,] thirdMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                for (int k = 0; k < secondMatrix.GetLength(0); k++)
                {
                    thirdMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                }
            }
        }
        ShowArray(thirdMatrix, "Результирующая матрица:");
    }
    else
    {
        Console.WriteLine("Матрицы нельзя перемножить.");
    }
}

void Task_60()
{
    FillTripleArray(2, 6, 6);
    Console.ReadLine();
}
void FillTripleArray(int firstDim, int secondDim, int thirdDim)
{
    int[,,] tripleArr = new int[firstDim, secondDim, thirdDim];

    int[] tempArr = new int[firstDim * secondDim * thirdDim];
    CreateUniqueArray(tempArr);
    int count = 0;

    for (int i = 0; i < tripleArr.GetLength(0); i++)
    {
        for (int j = 0; j < tripleArr.GetLength(1); j++)
        {
            for (int k = 0; k < tripleArr.GetLength(2); k++)
            {
                tripleArr[i, j, k] = tempArr[count];
                count++;
            }
        }
    }
    ShowTripleArray(tripleArr);
}
int[] CreateUniqueArray(int[] tempArr)
{
    for (int i = 0; i < tempArr.Length; i++)
    {
        tempArr[i] = rnd.Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (tempArr[i] == tempArr[j])
                {
                    tempArr[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    return tempArr;
}
void ShowTripleArray(int[,,] trArr)
{
    for (int i = 0; i < trArr.GetLength(0); i++)
    {
        for (int j = 0; j < trArr.GetLength(1); j++)
        {
            for (int k = 0; k < trArr.GetLength(2); k++)
            {
                Console.Write("Значение: " + trArr[i, j, k] + $" Индекс ({i}, {j}, {k}). ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void Task_62()
{
    int[,] array = FillSpiralArray(Prompt("Введите размерность:"));
    ShowArray(array, "Спиральный массив:");
    Console.ReadLine();
}
int[,] FillSpiralArray(int size)
{
    int[,] array = new int[size, size];
    int value = 1;
    int row = 0;
    int col = 0;
    
    while (value <= size * size)
    {
        for (int i = col; i < size - col; i++)
        {
            array[row, i] = value++;
        }
        row++;

        for (int i = row; i < size - row + 1; i++)
        {
            array[i, size - col - 1] = value++;
        }
        col++;

        for (int i = size - col - 1; i >= col - 1; i--)
        {
            array[size - row, i] = value++;
        }

        for (int i = size - row - 1; i >= row; i--)
        {
            array[i, col - 1] = value++;
        }
    }return array;
}