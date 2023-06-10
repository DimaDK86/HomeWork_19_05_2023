// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-99, 99);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}    ");
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
PrintArray(array);


System.Console.Write("Введите искомое значение: ");
int number = Convert.ToInt32(Console.ReadLine());

bool found = false;
int row = 0;
int col = 0;

for (int j = 0; j < array.GetLength(0); j++)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        if (array[i, j] == number)
        {
            found = true;
            row = i;
            col = j;
        }
    }
}

if (found)
{
    System.Console.WriteLine($"Элемент {number} найден в позиции: строка {row} столбец {col}");
}
else
{
    System.Console.WriteLine($"Элемент со значением {number} не найден");
}