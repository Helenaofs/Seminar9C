// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

Console.WriteLine("Введите минимальное число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число N:");
int n = int.Parse(Console.ReadLine());
int sum = 0;

void PrintSumNumbers(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.WriteLine(sum);
        return;
    }
    PrintSumNumbers(m, n - 1, sum);
}

PrintSumNumbers(m, n, sum);
