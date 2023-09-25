/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

int Prompt (string message)
{
    System.Console.Write(message); //Выводим приглашение ко вводу
    string readInput = System.Console.ReadLine(); //Вводим значение
    int result = int.Parse (readInput); //приводим к числу
    return result; //возвращаем результат
}

// метод для получения случайных чисел массива
int[] GenerateArray (int Length, int minValue, int maxValue)
{
    int[] array = new int [Length]; // объявляем массив
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1); // заполняем случайными цифрами из диапозона SatyArr до EndArr
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i< array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); //вывод значения массива
    }
    System.Console.Write($"{array[array.Length - 1]}"); //вывод значения массива
    System.Console.Write("]");
}

int length = Prompt("Длина массива: ");
int min = Prompt ("Начальное значение, для диапозона случайного числа: ");
int max = Prompt ("Конечное значение, для диапозона случайного числа: ");
int[] array = GenerateArray(length, min, max); //заполнение массива случайными числами
PrintArray(array); //вывод массива