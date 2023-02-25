Random random = new Random();
Menu();

void Menu() //Меню выбора задачи.
{
    bool flag = false;

    while (flag != true)
    {
        Console.Clear();
        Console.WriteLine("Меню выбора задачи.");
        Console.WriteLine("Введите цифру для выбора задачи:");
        Console.WriteLine("1 - Программа для вывода количества чётных чисел в массиве.");
        Console.WriteLine("2 - Программа для посчета суммы элементов массива, стоящих на нечётных позициях.");
        Console.WriteLine("3 - Программа для расчета разницы между максимальным и минимальным элементов массива.");
        Console.WriteLine("0 - Для выхода из программы.");
        
        bool access = int.TryParse(Console.ReadLine(),out int result);
        if (access == true)
        {
            switch (result)
            {
                case 1:
                Task_34();
                break;

                case 2:
                Task_36();
                break;

                case 3:
                Task_38();
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

int [] CreateAndFillingArray(int minDimension, int maxDimension, int minValue, int maxValue) //Метод для создания и заполнения массива псевдо-рандомными числами.
{                                                                                            //minDimension - минимальное число размерности массива для метода Random.Next
    int [] arr = new int [random.Next(minDimension, maxDimension)];                          //maxDimension - максимальное число размерности массива для метода Random.Next
                                                                                             //minValue - минимальное значение элемента массива метода Random.Next
    for (int i = 0; i < arr.Length; i++)                                                     //maxValue - максимальное значение элемента массива  метода Random.Next
    {
        arr [i] = random.Next(minValue,maxValue);
    }
    return arr;
}

void Task_34()
{
    int [] arr = CreateAndFillingArray(5, 11, 100, 1000);

    int count = FindEvenNumbersOfArray(arr);

    Console.WriteLine(String.Join(" ", arr));
    Console.WriteLine($"Количество положительных элементов в массиве: {count}");
    Console.ReadLine();
}

int FindEvenNumbersOfArray(int [] arr) //Поиск четных элементов в переданном массиве и их посчет. Относится к Task_34.
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

 void Task_36()
{
    int [] arr = CreateAndFillingArray(5, 11, 0, 20);
    int sum = SumOfElementsOfOddIndex(arr);

    Console.WriteLine(String.Join("   ", arr));
    Console.WriteLine($"Сумма элементов на нечетных индексах = {sum}");
    Console.ReadLine();
}

int SumOfElementsOfOddIndex(int [] arr) //Метод для посчета суммы элементов с нечетным индексом. Относится к Task_36.
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

 void Task_38()
{
    int [] arr = CreateAndFillingArray(5, 11, 0 , 20);
    int dif = FindDifferenceMinAndMaxValue(arr);

    Console.WriteLine(String.Join("   ", arr));
    Console.WriteLine($"Разница между минимальным и максимальным значениями = {dif}");
    Console.ReadLine();

}

int FindDifferenceMinAndMaxValue(int[] arr) //Метод для поиска разницы между минимальным и максимальным значениями. Относится к Task_38.
{
    int minValue = arr[0];
    int maxValue = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if(arr [i] < minValue)
        {
            minValue = arr[i];
        }
        if (arr [i] > maxValue)
        {
            maxValue = arr[i];
        }
    }

    return maxValue - minValue;
}