// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и m.
// m = 2, m = 3 -> A(m,m) = 29


Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число m:");
int m = int.Parse(Console.ReadLine());
int ackermanFunction = A(m, n);

int A(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return A(m - 1, 1);
  else return A(m - 1, A(m, n - 1));
}

Console.Write($"A(m,n) = {ackermanFunction} ");
