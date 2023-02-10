using System;

Example_04();

static void PowNumber()
{
    System.Console.WriteLine("Введите число, которое хотите возвести в квадрат");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    int result = userNumber * userNumber;
    
    System.Console.WriteLine($"Квадрат числа {userNumber} = {result}");
    System.Console.ReadLine();
}

static void Example_01()
{
    System.Console.WriteLine("Введите первое число");
    int number_01 = Convert.ToInt32(System.Console.ReadLine());
    System.Console.WriteLine("Введите второе число");
    int number_02 = Convert.ToInt32(System.Console.ReadLine());

    if (number_01 == number_02 * number_02){
        System.Console.WriteLine("Квадрат второго числа равен первому числу");
    }
    else 
    {
        System.Console.WriteLine("Нет");
        
    }
    System.Console.ReadLine();
}

static void Example_02 ()
{
    System.Console.WriteLine("Введите день недели в виде числа");
    int a = Convert.ToInt32(System.Console.ReadLine());
    switch (a)
    {
    case 1:
        System.Console.WriteLine("День недели: понедельник");
        break;
    case 2:
        System.Console.WriteLine("День недели: вторник");
        break;
    case 3:
        System.Console.WriteLine("День недели: среда");
        break;
    case 4:
        System.Console.WriteLine("День недели: четверг");
        break;
    case 5:
        System.Console.WriteLine("День недели: пятница");
        break;
    case 6:
        System.Console.WriteLine("День недели: суббота");
        break;
    case 7:
        System.Console.WriteLine("День недели: воскресенье");
        break;
    default:
        System.Console.WriteLine("День недели: неизведанное");
        break;
    }
}

static void Example_03()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int minusNumber = -number;

    while (minusNumber <= number)
    {
        Console.Write($"{minusNumber}\t");
        minusNumber++;
    }
    Console.ReadLine();
}

static void Example_04()
{
    System.Console.WriteLine("Введите трехзначное и более число");
    int userNumber = Convert.ToInt32(Console.ReadLine());

    int result = userNumber % 10;
    System.Console.WriteLine($"Последняя цифра числа {userNumber} является {result}");
    Console.ReadLine();

}