Console.Clear();
Console.WriteLine("1 - Программа для замены положительного на отрицательный знак и наоборот.");
Console.WriteLine("2 - Программа для поиска заданного числа в массиве.");
Console.WriteLine("3 - Программа ");
Console.WriteLine("4 - Программа ");
int numberOfTask = Prompt("Введите номер задачи");
switch (numberOfTask)
            {
                case 1:
                Console.Clear();
                Task_32();
                break;

                case 2:
                Console.Clear();
                Task_33();
                break;

                case 3:
                Console.Clear();
                Task_35();
                break;

                case 4:
                Console.Clear();
                Task_37();
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

static void Task_32()
{
    int [] arr = new int [8];
    Random random = new Random();
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = random.Next(-10, 11);
        Console.Write($"{arr[index]}\t");
    }
    Console.WriteLine();
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] *= -1;
        Console.Write($"{arr[index]}\t");
    }
}

static void Task_33()
{
    
    int [] arr = {6, 7, 19, 345, 3};
    int number = Prompt("Введите число для поиска");

    int index = 0;

    if(FoundNumberOfArray(arr, number, out index))
    {
        Console.WriteLine($"Элемент {number} найден под индексом {index}.");
    }
    else
    {
        Console.WriteLine($"Элемент {number} не найден.");
    }   
    
}

static bool FoundNumberOfArray(int [] arr, int userNumber, out int index)
{
    for (index = 0; index < arr.Length; index++)
    {
        if (arr[index] == userNumber)
        {
            return true; 
        }        
    }
    return false;
}

static void Task_35()
{
    int [] arr = new int [123];
    Random random = new Random();
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(0, 500);
        if (arr[i] >= 10 && arr[i] < 100)
        {
            count++;
        }
    }

    foreach (var item in arr)
    {
        Console.Write($"{item}\t");
    }
    Console.WriteLine();
    Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");
}

static void Task_37()
{
    int [] arr = {1, 2, 3, 4, 5};
    int [] arr2;
    
    if (arr.Length % 2 != 0) // проверка на четность и нечетность кол-ва эл. массива
    {
        arr2 = new int [arr.Length / 2 + 1];
        arr2 [arr.Length / 2] = arr[arr.Length / 2];
    }
    else
    {
        arr2 = new int [arr.Length / 2];
    }

    for (int i = 0; i < arr.Length / 2; i++)
    {
        arr2[i] = arr[i] * arr [arr.Length - i -1];
    }

    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine(String.Join(" ", arr2));
}