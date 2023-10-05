/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] сумма положительных чисел равна 29,
сумма отрицательных равна -20.
*/

using System;

class Program
{
    static int[] GetArray(int length, int minValue = -9, int maxValue = 9)
    {
        int[] array = new int[length];
        Random random = new Random();
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (int el in array)
        {
            Console.Write(el + " ");
        }
        Console.WriteLine();
    }

    static int GetSumOfPositiveNumbers(int[] array)
    {
        int sum = 0;
        foreach (int item in array)
        {
            if (item > 0)
                sum += item;
        }
        return sum;
    }

    static int GetSumOfNegativeNumbers(int[] array)
    {
        int sum = 0;
        foreach (int item in array)
        {
            if (item < 0)
                sum += item;
        }
        return sum;
    }

    static void Main(string[] args)
    {
        int length = 12;
        int[] array = GetArray(length);

        PrintArray(array);

        int sumOfPositiveNumbers = GetSumOfPositiveNumbers(array);
        int sumOfNegativeNumbers = GetSumOfNegativeNumbers(array);

        Console.WriteLine("Сумма положительных чисел: " + sumOfPositiveNumbers);
        Console.WriteLine("Сумма отрицательных чисел: " + sumOfNegativeNumbers);
    }
}