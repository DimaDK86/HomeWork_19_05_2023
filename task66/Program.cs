// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

void Numbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    else
    {
        Numbers(m, n -1);
        System.Console.Write(n + ", ");
    }
}

int Summ(int m, int n)
{
    int sum = m;
    while (true)
    {
        sum += n;
        n--;
        if (n == m)
            break;
    }
    System.Console.WriteLine($"{sum}");
    return sum;
}

Console.Clear();
System.Console.Write("Введите целое число M: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Числа от M ({m}) до N ({n})");
Numbers(m, n);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма чисел в диапозоне от M до N, равна ");
Summ(m, n);