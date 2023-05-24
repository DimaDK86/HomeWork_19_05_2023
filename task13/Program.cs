// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.Через строку решать нельзя.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Clear();
System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
int num2 = num;

while (num >= 10)
{
    num = num / 10;
    count++;
}

if (count < 3)
{
    System.Console.WriteLine("Вы ввели число, с меньшим количеством знаков чем 3");
    System.Console.WriteLine($"разрядность введеного числа {count}");
    return;
}
while (num2 > 999)
{
    num2 = num2 / 10;
}    
int result = num2 % 10;
System.Console.WriteLine($"{result}");