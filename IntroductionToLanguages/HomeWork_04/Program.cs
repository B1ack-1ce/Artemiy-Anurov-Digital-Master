using System;

Menu();

static void Menu() //Меню выбора задачи
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи.");
        Console.WriteLine("Введите цифру для выбора задачи:");
        Console.WriteLine("1 - Программа для возведения числа в степень.");
        Console.WriteLine("2 - Программа для вывода суммы цифр в числе.");
        Console.WriteLine("3 - Программа задающая и выводящая массив из N элементов на экран.");
        Console.WriteLine("0 - Для выхода из программы.");
        
        bool access = int.TryParse(Console.ReadLine(),out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                Task_25();
                break;

                case 2:
                Task_27();
                break;

                case 3:
                Task_29();
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

static int Prompt(string message) //Метод для упрощения ввода числа с консоли
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task_25()
{
    Console.Clear();
    int userNumber = Prompt("Введите число, которое нужно возвести в степень.");
    int degree = Prompt("Введите степень, в которую хотите возвести введенное ранее число");

    int result = Pow(userNumber, degree);
    Console.WriteLine($"\nЧисло {userNumber} в степень {degree} = {result} ");
    Console.ReadLine();
}

static int Pow(int number, int degree) //Метод возведения числа в степень. Относится к Task_25.
{
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    
    return result;
}

static void Task_27()
{
    int userNumber = Prompt("Введите число для вывода суммы цифр в числе.");
    int result = SumOfNumbers(userNumber);
    Console.WriteLine($"Сумма цифр в числе {userNumber} = {result}");
    Console.ReadLine();
}

static int SumOfNumbers(int userNumber) //Метод для подсчета суммы цифр в числе
{
    int result = 0;
    for (int i = 0; userNumber > 0; i = 0) //Немножко извращенный цикл :-)
    {
        i = userNumber % 10;
        userNumber /= 10;
        result += i;
    }
    return result;
}

static void Task_29()
{
    Console.Clear();
    int countOfElements = Prompt("Сколько элементов вы хотите создать в массиве.");
    int [] userArr = CreateArrOfNumbers(countOfElements);
    for (int i = 0; i < userArr.Length; i++)
    {
        Console.Write($"{userArr[i]}\t");
    }
    Console.ReadLine();
}

static int [] CreateArrOfNumbers(int countsOfElementsArr) //Метод для создания заданной размерности массива и его заполнения
{
    int [] result = new int[countsOfElementsArr];
    for (int i = 0; i < result.Length; i++)
    {
        Console.Clear();
        result [i] = Prompt($"Введите {i + 1} элемент массива.");
    }
    return result;
}