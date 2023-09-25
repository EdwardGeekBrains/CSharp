/* 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 -> 2
85 -> 8
*/
int GetRandomNumber (int minValue = 10, int maxValue = 99)
{
    return new Random().Next(minValue, maxValue +1);
}

int GetMaxDigit(int twoDigitNumber)
{
    int digit_1 = twoDigitNumber / 10;   //8
    int digit_2 = twoDigitNumber % 10;   // 3
    return digit_1 > digit_2 ? digit_1 : digit_2;
}

int number = GetRandomNumber();
Console.WriteLine(number);
Console.WriteLine(GetMaxDigit(number));