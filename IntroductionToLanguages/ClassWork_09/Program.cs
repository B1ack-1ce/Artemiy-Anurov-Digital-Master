using System;

Menu();

void Menu() // Меню выбора задач.
{
    Console.Clear();
    Console.WriteLine("1 - Программа для ");
    Console.WriteLine("2 - Программа для ");
    Console.WriteLine("3 - Программа для ");
    Console.WriteLine("4 - Программа для ");
    int numberOfTask = Prompt("Введите номер задачи");
    switch (numberOfTask)
    {
        case 1:
            Console.Clear();
            Task_65();
            break;

        case 2:
            Console.Clear();
            Task_67();
            break;

        case 3:
            Console.Clear();
            Task_69();
            break;

        case 4:
            Console.Clear();
            //Task_59();
            break;

        default:
            Console.WriteLine("Номер задачи введен некорректно.");
            break;
    }
}

int Prompt(string message) //Метод для упрощения ввода числа с консоли
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Task_65()
{
    int firstNum = Prompt("Введите первое число");
    int secondNum = Prompt("Введите последнее число");

    Console.WriteLine($"Все натуральные числа от {firstNum} до {secondNum}:");
    Console.WriteLine(FindNaturalNumbers(firstNum, secondNum));
    Console.ReadLine();
}

int FindNaturalNumbers(int firstNum, int secondNum)
{
    if(firstNum == secondNum) return secondNum;
    Console.Write(firstNum  + " ");
    return FindNaturalNumbers(firstNum + 1, secondNum);
}

void Task_67()
{
    int sum = FindSumNum(Prompt("Введите число."));
    Console.WriteLine(sum);
    Console.ReadLine();
}

int FindSumNum(int userNum)
{
    if(userNum / 10 == 0) return userNum; 
    return userNum % 10 + FindSumNum(userNum /= 10);
}

void Task_69()
{
    int foundation = Prompt("Введите основание.");
    int degree = Prompt("Введите степень.");
    int powNum = PowNumber(foundation, degree);
    Console.WriteLine($"Число {foundation} в степени {degree}: {powNum}");
    Console.ReadLine();
}

int PowNumber(int foundation, int degree)
{
    if(degree == 1) return foundation ;
    else if(degree == 0) return 1;
    return foundation  * PowNumber(foundation, degree - 1);
}