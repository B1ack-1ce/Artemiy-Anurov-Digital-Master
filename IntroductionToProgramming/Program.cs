using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToProgramming
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FoundAverageOfArray();
        }
        /// <summary>
        /// Метод реверса заданного массива.
        /// </summary>
        private static void ArrayReverse()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            int change;
            int index = 0;

            while (index < array.Length / 2)
            {
                change = array[array.Length - 1 - index];
                array[array.Length - 1 - index] = array[index];
                array[index] = change;
                index++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Метод вычисления среднеарифметического из заданного массива
        /// </summary>
        private static void FoundAverageValueOfArray()
        {
            int[] arrayOfNumbers = { 4, 6, 8, 10, 12 };
            int avarageValueOfArray = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                avarageValueOfArray += arrayOfNumbers[i];
            }

            avarageValueOfArray /= arrayOfNumbers.Length;

            Console.WriteLine($"Среднее значение элементов массива: {avarageValueOfArray}");
            Console.ReadKey();
        }
        /// <summary>
        /// Метод поиска минимального и максимального значения элемента в массиве.
        /// </summary>
        private static void FoundIndexOfMinAndMaxValueInArray()
        {
            int[] arrayOfNumbers = { -15, 4, -35, 2, -10, 100, 125, -5, 0, 9, -30 };

            int minValue = 0;
            int indexMinValue = 0;

            int maxValue = 0;
            int indexMaxValue = 0;

            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {

                if (maxValue <= arrayOfNumbers[i])
                {
                    indexMaxValue = i;
                    maxValue = arrayOfNumbers[i];
                }

                if (minValue >= arrayOfNumbers[i])
                {
                    indexMinValue = i;
                    minValue = arrayOfNumbers[i];
                }
            }
            Console.WriteLine($"Минимальное число: {minValue} находится под индексом {indexMinValue}\nМаксимальное число: {maxValue} находится под индексом {indexMaxValue} ");
            Console.ReadKey();
        }
        /// <summary>
        /// Метод подсчета количество положительных чисел в массиве
        /// </summary>
        private static void FindTheNumberOfPositiveNumbers()
        {
            int[] array = { -2, 8, 14, -34, -9, 7, 7, 4 };
            int countPositiveNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    countPositiveNumbers++;
                }
            }

            Console.WriteLine($"Количество позитивных чисел равна {countPositiveNumbers}");
            Console.ReadLine();
        }
        /// <summary>
        /// Метод, перемещающий максимальное значение в правую часть массива
        /// </summary>
        private static void ABC()
        {
            int[] array = { 2, 5, 13, 7, 6, 4 };
            int index = 0;

            int max = array[0];
            int max_index = 0;

            while (index < array.Length) 
            {
                if (array[index] > max)
                {
                    max = array[index];
                    max_index = index;
                }

                index++;
            }

            array[max_index] = array[array.Length - 1];
            array[array.Length - 1] = max;
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Что то там с собакой
        /// </summary>
        private static void BBC()
        {
            int count = 0;
            int distance = 10000;
            int time = 0;

            int first_friend_speed = 1;
            int second_friend_speed = 2;
            int dog_speed = 5;

            int is_friend = 2;

            while (distance > 10)
            {
                if (is_friend == 1)
                {
                    time = distance / (first_friend_speed + dog_speed);
                    is_friend = 2;
                }
                else
                {
                    time = distance / (second_friend_speed + dog_speed);
                    is_friend = 1;
                }

                distance -= (first_friend_speed + second_friend_speed) * time;
                count++;
            }
            Console.WriteLine($"Собака пробежит от друга к другу {count} раз.");
            Console.ReadKey();
        }
        /// <summary>
        /// Метод, выполняющий сортировку массива
        /// </summary>
        private static void ArraySorting()
        {
            int[] numbers = { 77, 46, 11, 89, 48, 14, 67, 73, 22, 26 };

            int sorted_size = 0;
            //int size = numbers.Length;
            int temp = 0;

            while (sorted_size < numbers.Length - 1)
            {
                int index = 0;
                while (index < (numbers.Length - 1 - sorted_size))
                {
                    if (numbers[index] > numbers[index + 1])
                    {
                        temp = numbers[index];
                        numbers[index] = numbers[index + 1];
                        numbers[index + 1] = temp;
                    }
                    index++;
                }
                sorted_size++;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]}\t");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Домашнее задание: Блок 3, задание 1. Нахождение среднего арифметического среди всех элементов массива
        /// </summary>
        private static void FoundAverageOfArray()
        {
            int[] numbers = { 2, 5, 13, 7, 6, 4 };
            int sum = 0;
            int avg = 0;

            int size = numbers.Length;
            int index = 0;

            while (index < size)
            {
                sum += numbers[index];
                index++;
            }
            avg = sum / size;

            Console.WriteLine($"Среднее значение в массиве равна {avg}");
            Console.ReadKey();
        }

        
    }
}
