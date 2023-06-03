// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. Math.Pow юзать нельзя.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();


void result(int a, int b)
{
    int num = 1;
    for (int i = 1; i <= b; i++)
    {
        num = num * a;
    }
    System.Console.WriteLine(num);
}


System.Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"Число {a}, в степени {b}, равно ");
result(a, b);
