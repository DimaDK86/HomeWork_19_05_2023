﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите элемент массива с индексом {i} - ");
        array[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();
}


Console.Write("Введите размер массива - ");
int array = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[array];

FillArray(numbers);
System.Console.Write("Массив: ");
PrintArray(numbers);


int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество значений в массиве больше 0, равно: {sum}");
