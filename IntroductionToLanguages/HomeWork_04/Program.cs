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
        Console.WriteLine("2 - Программа для .");
        Console.WriteLine("3 - Программа для .");
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
                //Task_29();
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

}

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/