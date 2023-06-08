// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

void FillArray(decimal[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDecimal(new Random().Next(100,1000)) / 10;
        }
}

void PrintArray(decimal[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        System.Console.Write(numbers[i] + " ");
    }
    System.Console.WriteLine();
}


System.Console.WriteLine("Введите размер массива  ");
int array = Convert.ToInt32(Console.ReadLine());
decimal[] numbers = new decimal[array];
FillArray(numbers);
System.Console.Write("Ваш массив -  ");
PrintArray(numbers);

decimal min = numbers[0];
decimal max = numbers[0];

for (int x = 0; x < numbers.Length; x++)
{
    if (numbers[x] > max)
        {
            max = numbers[x];
        }
    if (numbers[x] < min)
        {
            min = numbers[x];
        }
}

System.Console.WriteLine($"Максимальное значение = {max}");
System.Console.WriteLine($"Минимальное значение = {min}");
System.Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");