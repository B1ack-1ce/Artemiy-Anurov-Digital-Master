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
        Console.WriteLine("3 - Программа для .");
        Console.WriteLine("4 - Программа для .");
        Console.WriteLine("5 - Программа для .");
        Console.WriteLine("6 - Программа для .");
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

                case 6:
                    Console.Clear();
                    Task_61(); //Доп. задача.
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
/*
Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
void Task_54()
{
    int[,] array = FillArray(Prompt("Введите первую размерность."), Prompt("Введите вторую размерность."));
    ShowArray(array);


    Console.ReadLine();
}

void SortArray(int[,] arr)
{
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        temp = arr[i, 0];
        for (int j = 1; j < arr.GetLength(1); j++)
        {

        }
    }
}
/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
void Task_56()
{
    int[,] array = FillArray(Prompt("Введите первую размерность."), Prompt("Введите вторую размерность."));
    ShowArray(array);
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
/*
Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3

Результирующая матрица будет:
18 20
15 18
*/
void Task_58()
{

}
/*
Задача 60. 
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
void Task_60()
{

}
/*
Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/
void Task_62()
{

}
/*
Необязательное задание:
Задача 61: 
Вывести первые N строк треугольника Паскаля. 
Сделать вывод в виде равнобедренного треугольника
*/
void Task_61() //Доп. задача.
{

}