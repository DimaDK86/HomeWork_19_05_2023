// Задача необязательная 1:
// на входе целое или вещественное число,
// надо удалить вторую цифру слева целой части этого числа.

// 145 -> 15
// 1 -> нет
// 567,123 -> 57,123

Console.Clear();

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num;
int num3 = 1;
int count = 1;
int result = 1;
int count2 = 1;

while (num >= 10)
{
     num = num / 10;
     count++;
}

if (count == 1)
{
    System.Console.WriteLine("Второй цифры нет...");
    System.Console.WriteLine($"разрядность введеного числа {count}");
    return;
}

else if (count == 2)
{
    result = num2 / 10;
    System.Console.WriteLine($"{result}");
    return;
}

else
        while (count > count2+1)
        {
            num3 = num3 * 10 ;
            count--;
        }  
         result = num2 % num3;
         System.Console.WriteLine($"{num}{result}");