// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// System.Console.WriteLine("1 - ПН / 2 - ВТ.... 7 - ВС");

Console.Clear();
d:
System.Console.WriteLine("Введите цифру от 1 до 7:");
int day = Convert.ToInt32(Console.ReadLine());

while(day == 0 || day > 7)
{
    System.Console.WriteLine("Это не день недели, повторите ввод");
    goto d;
}

if(day > 5 && day < 8)
    System.Console.WriteLine("Выходной день");
    
else if(day <= 5)
    System.Console.WriteLine("Будний день");
