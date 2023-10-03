/* Задача 30: Напишите программу, которая
выводит массив из 8 элементов, заполненный
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

int length = 8;
int[] array = new int [length];
for (int i = 0; i < length; i++)
{
    array [i] = new Random().Next(2);
}

for (int i = 0; i < length; i++)
{
    if (i == length -1)
    System.Console.Write(array[i]);
    else
    System.Console.Write(array[i] + ",");
}