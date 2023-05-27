// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом. Через строку решать нельзя.

Console.Clear();

A:

System.Console.WriteLine("Введите пятизначное число:");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num % 100 / 10;
int num5 = num % 10;


if (num < 10000 || num > 100000)
{
    System.Console.WriteLine($"{num} - введенное число не 'пятизначное'");
    goto A;
}

else if (num1 == num5 && num2 == num4)
{
    System.Console.WriteLine("Введенное число - палиндромом!");
}

else
    System.Console.WriteLine($"Введенное число {num} - НЕ палиндромом!");