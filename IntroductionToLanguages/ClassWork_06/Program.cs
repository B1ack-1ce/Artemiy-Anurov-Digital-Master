using System;

Menu();

void Menu() // Меню выбора задач.
{
    Console.Clear();
    Console.WriteLine("1 - Программа для реверса массива.");
    Console.WriteLine("2 - Программа для проверки на существование треугольника. ");
    Console.WriteLine("3 - Программа для перевода десятичного числа в двоичное.");
    Console.WriteLine("4 - Программа для .");
    Console.WriteLine("5 - Программа для .");
    int numberOfTask = Prompt("Введите номер задачи");
    switch (numberOfTask)
    {
        case 1:
            Console.Clear();
            Task_39();
            break;

        case 2:
            Console.Clear();
            Task_40();
            break;

        case 3:
            Console.Clear();
            Task_42();
            break;

        case 4:
            Console.Clear();
            Task_44();
            break;

        case 5:
            Console.Clear();
            Task_45();
            break;

        default:
            Console.WriteLine("Номер задачи введен некорректно.");
            break;
    }
}

static int Prompt(string message)// Метод запроса числа.
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] GenerateArray(int length)// Генерация массива с рандомными числами.
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-10, 11);
    return array;
}

void PrintArray(int[] array)// Вывод массива.
{
    Console.WriteLine(String.Join(" ", array));
}

void Task_39()// Демонстрационная задача.
{
    int[] array = GenerateArray(Prompt("Введите желаемую размерность массива."));
    PrintArray(array);
    ReverseArray(array);
    PrintArray(array);
    Console.ReadLine();
}

int[] ReverseArray(int[] array)// Реверс массива.
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

int[] AnotherReverseArray(int[] array)// Альтернативный реверс массива.
{
    int[] tmpArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        tmpArray[i] = array[array.Length - 1 - i];
    return tmpArray;
}

void Task_40()
{
    int[] trNumbers = new int[3];

    for (int i = 0; i < trNumbers.Length; i++)
    {
        trNumbers[i] = Prompt($"Введите {i + 1} сторону треугольника");
    }

    if (IsExistenceTriangle(trNumbers))
    {
        Console.WriteLine($"Треугольник со сторонами: {trNumbers[0]}, {trNumbers[1]}, {trNumbers[2]} может существовать.");
    }
    else Console.WriteLine("Такого треугольника существовать не может.");

}

bool IsExistenceTriangle(int[] trNum) //Проверка на существование треугольника.
{
    if (trNum[0] < trNum[1] + trNum[2] && trNum[1] < trNum[0] + trNum[2] && trNum[2] < trNum[0] + trNum[1]) return true;
    else return false;
}

void Task_42()
{
    int number = Prompt("Введите число для перевода из десятичной в двоичную");
    int[] binaryNum = NumberTranslationFrom10To2(number);

    Console.WriteLine("Двоичный формат: " + String.Join(" ", binaryNum));
    Console.ReadLine();
}

int CalculationDimension(int userNumber) //Рассчет нужной размерности.
{
    int count = 0;
    while (userNumber > 0)
    {
        userNumber /= 2;
        count++;
    }
    return count;
}

int[] NumberTranslationFrom10To2(int userNumber) //Перевод десятичного числа в двоичное.
{
    int[] binaryArray = new int[CalculationDimension(userNumber)];
    for (int i = 0; i < binaryArray.Length; i++)
    {
        binaryArray[i] = userNumber % 2;
        userNumber /= 2;
    }
    Array.Reverse(binaryArray);
    return binaryArray;
}

void Task_44()
{

}

void Task_45()
{

}

/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/