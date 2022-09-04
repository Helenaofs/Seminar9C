//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

using System;

Console.WriteLine("Введите число M:");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int n = int.Parse(Console.ReadLine());

void PrintNumbers(int m, int n)
{
   int min = m;
   int max = n;
   if (min > max)
   {
    min = n;
    max = m;
   }
   for (int i = min; i <= max; i++)
   {
        Console.Write($"{i} ");
   }
}

PrintNumbers(m, n);
