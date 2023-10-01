/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
A (3,6,8); B (2,1,-7), -> 15.84
A (7, -5, 0); B(1, -1, 9) -> 11,53
*/

using System;

class Program
{
    static int[] ReadPointCoords()
    {
        string[] input = Console.ReadLine()!.Split(' ');
        int x = Convert.ToInt32(input[0]);
        int y = Convert.ToInt32(input[1]);
        int z = Convert.ToInt32(input[2]);
        int[] point = new int[] { x, y, z };
        return point;
    }

    static double FindDistance(int[] pointA, int[] pointB)
    {
        int ax = pointA[0];
        int ay = pointA[1];
        int az = pointA[2];
        int bx = pointB[0];
        int by = pointB[1];
        int bz = pointB[2];
        double distance = Math.Sqrt((ax - bx) * (ax - bx) + (ay - by) * (ay - by) + (az - bz) * (az - bz));
        return distance;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите координаты первой точки:");
        int[] pointA = ReadPointCoords();

        Console.WriteLine("Введите координаты второй точки:");
        int[] pointB = ReadPointCoords();

        Console.WriteLine($"{FindDistance(pointA, pointB):F2}");
    }
}