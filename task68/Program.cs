// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Numbers(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Numbers(m - 1, 1);
    }
    else
    {
        return (Numbers(m - 1, Numbers(m, n - 1)));
    }
}

Console.Clear();
System.Console.Write("Введите целое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Numbers(m, n));