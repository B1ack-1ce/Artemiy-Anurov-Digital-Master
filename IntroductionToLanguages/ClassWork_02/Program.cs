using System;
//Example_01();
//Example_02();
//Example_03();
//Example_04();

static void Example_01() //Программа, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
{
    Console.Clear();
    Random random = new Random();
    int randomNumber = random.Next(100, 1000);

    int firstNumber = randomNumber / 100;
    int lastNumber = randomNumber % 10;

    Console.WriteLine($"Было число {randomNumber}");
    Console.WriteLine($"Стало число {firstNumber}{lastNumber}");
    
}

static void Example_02() //Программа, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
{
    Console.Clear();
    Console.WriteLine("Введите первое число для сравнения");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число для сравнения");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    if (firstNumber * firstNumber == secondNumber || firstNumber == secondNumber * secondNumber)
        Console.WriteLine($"Одно из чисел является квадратом другого");
        else 
        Console.WriteLine($"Числа разные");
} 

static void Example_03() //Программа, которая принимает на вход 2 числа и проверяет, делится ли первое число на второе без остатка.
{
    Console.Clear();
    Console.WriteLine("Введите первое число для сравнения");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число для сравнения");
    int secondNumber = Convert.ToInt32(Console.ReadLine());

    int remains = firstNumber % secondNumber;

    if (firstNumber % secondNumber == 0)
    {
        Console.WriteLine($"Первое число {firstNumber} кратен второму числу {secondNumber}");
    }
    else
    {
        Console.WriteLine($"Числа не кратны друг другу.\nОстаток от деления = {remains}");
    }
}

static void Example_04() //Программа, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
{
    Console.Clear();
    Console.WriteLine("Введите  число для проверки кратности на 7 и 23");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine($"Число {number} кратен числу 7 или 23");
    }
    else
    {
        Console.WriteLine("Число не кратное 7 или 23");
    }
}
