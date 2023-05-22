// Задача 7 - Напишите программу, которая принимает на вход целое число любой разрядности
// и на выходе показывает третью цифру слева этого числа или говорит, что такой цифры нет.
// Через строку решать нельзя.

// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет

Console.Clear();

System.Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 >= 100)
{
    while (num1 / 1000 > 0)
    {
        num1 = num1 / 10;
    }
    int num2 = num1 % 10;
        System.Console.WriteLine("Третья цифра " +num2);
}
else
    System.Console.WriteLine("Третьей цифры - нет");