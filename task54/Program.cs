﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
System.Console.Write("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];


FillArray(array);
System.Console.WriteLine("Входящий Массив");
PrintArray(array);


for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
    {
        for (int x = 0; x < array.GetLength(1) - 1; x++)
        {
            if (array[i, x] < array[i, x + 1])
           {
                int temp = 0;
                temp = array[i, x];
                array[i, x] = array[i, x + 1];
                array[i, x + 1] = temp;
            }
        }
    }
}


Console.WriteLine();
Console.WriteLine("Массив с упорядоченными по убыванию элементами каждой строки");
PrintArray(array);