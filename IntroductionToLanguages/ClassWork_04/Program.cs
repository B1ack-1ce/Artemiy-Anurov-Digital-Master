Console.Clear();
Console.WriteLine("1 - Программа для поиска количества цифр в числе.");
Console.WriteLine("2 - Программа для вывода произведения чисел от 1 до N.");
Console.WriteLine("3 - Программа для вывода массива из 8 элементов с 0 и 1.");
int numberOfTask = Prompt("Введите номер задачи");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task_26();
                break;

                case 2:
                Console.Clear();
                Task_28();
                break;

                case 3:
                Console.Clear();
                Task_30();
                break;

                default:
                Console.WriteLine("Номер задачи введен некорректно.");
                break;
            }

static int Prompt(string message)// Метод запроса числа.
{
    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void Task_26()// Метод подсчета цифр в числе.
{
    int number = Prompt("Введите число для подсчета кол-ва цифр в числе.");
    CountOfNumber(number);
}

static void CountOfNumber (int userNumber)
{
    char [] number = userNumber.ToString().ToCharArray();
    Console.WriteLine($"{number.Length }");
}

static void Task_28()// Метод нахождения произведения чисел от 1 до N.
{
    int number = Prompt("Введите число для вывода произведения от 1 до N.");
    int result = MultiPly(number);
    Console.WriteLine($"\nПроизведение чисел от 1 до {number} = {result}.");
}

static int MultiPly(int userNumber)
{
    int result = 1;
    for (int i = 1; i <= userNumber; i++)
    {
        result *= i;
    }
    return result;
}

static void Task_30()
{
    Random random = new Random();
    int [] arr = new int [8];

    for (int i = 0; i < arr.Length; i++)
    {
        arr [i] = random.Next(0,2);
        //Console.Write(arr[i] + " ");
    }
    string array = String.Join("_", arr);
    Console.WriteLine(array);
}