// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.

Console.Clear();
System.Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int num2 = num;

while (num >= 10)
{
    num = num / 10;
    count++;
}

if (count != 3)
{
    System.Console.WriteLine("Вы ввели не трех значное число");
    System.Console.WriteLine($"разрядность введеного числа {count}");
    return;
}
int result = num2 / 10 % 10;
System.Console.WriteLine($"{result}");