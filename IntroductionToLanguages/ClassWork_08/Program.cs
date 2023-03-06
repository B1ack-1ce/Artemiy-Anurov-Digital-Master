using System;

Menu();

void Menu() // Меню выбора задач.
{
    Console.Clear();
    Console.WriteLine("1 - Программа для ");
    Console.WriteLine("2 - Программа для ");
    Console.WriteLine("3 - Программа для ");
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