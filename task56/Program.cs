// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],6}");
        System.Console.WriteLine();
    }
}


Console.Clear();
System.Console.Write("Введите размер массива ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];


FillArray(array);
System.Console.WriteLine("Массив");
PrintArray(array);

int line = -1;
int sumlineminimum = Int32.MaxValue;

for (int i = 0; i < array.GetLength(1); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sum = sum + array[i, j];        
    }
    if (sum <= sumlineminimum)
    {
        sumlineminimum = sum;
        line++;
    }
    System.Console.WriteLine($"{sum}");
}

System.Console.WriteLine($"Cтрока с индексом {line}, с наименьшей суммой элементов");
System.Console.WriteLine($"Сумма элентов строки равна {sumlineminimum}");