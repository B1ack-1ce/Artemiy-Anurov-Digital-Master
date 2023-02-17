

static int Prompt(string message)
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task_01()
{
    Console.Clear();
    int userNumber = Prompt("Введите номер четверти.");

    switch (userNumber)
            {
                case 1:
                System.Console.WriteLine("Координаты x > 0 и y > 0.");
                break;

                case 2:
                System.Console.WriteLine("Координаты x < 0 и y > 0.");
                break;

                case 3:
                System.Console.WriteLine("Координаты x < 0 и y < 0.");
                break;

                case 4:
                System.Console.WriteLine("Координаты x > 0 и y < 0.");
                break;

                default:
                System.Console.WriteLine("Четверть не найдена.");
                break;
            }

}

static void Task_02()
{
    Console.Clear();
    int userNumber = Prompt("Введите число больше 0.");

    for (int i = 1; i <= userNumber; i++)
    {
        System.Console.Write($"{i * i}\t");
    }
}

static void Task_03()
{
    Console.Clear();

    int firstPointX = Prompt("Введите координату X первой точки.");
    int firstPointY = Prompt("Введите координату Y первой точки.");

    int secondPointX = Prompt("Введите координату X второй точки.");
    int secondPointY = Prompt("Введите координату Y второй точки.");

    double distance = Math.Sqrt(Math.Pow(secondPointX - firstPointX, 2) + Math.Pow(secondPointY - firstPointY, 2));

    Console.WriteLine($"Введенные координаты:\nПервая точки:{firstPointX},{secondPointX}\nВторая точка: {firstPointY}, {secondPointY}\nРасстояние между точками = {distance:f2}");
}