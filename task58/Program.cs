// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 9);
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
System.Console.Write("Введите размер матрицы ");
int rows = Convert.ToInt32(Console.ReadLine());
int cols = rows;
int[,] array = new int[rows, cols];


FillArray(array);
System.Console.WriteLine("Матрица №1");
int[,] firstMatrix = array;
PrintArray(array);

FillArray(array);
System.Console.WriteLine("Матрица №2");
int[,] secondMatrix = array;
PrintArray(array);

int rows1 = firstMatrix.GetLength(0);
int cols1 = firstMatrix.GetLength(1);
int rows2 = secondMatrix.GetLength(0);
int cols2 = secondMatrix.GetLength(1);

int[,] result = new int[rows1, cols2];
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        int sum = 0;
        for (int k = 0; k < cols1; k++)
        {
            sum += firstMatrix[i, k] * secondMatrix[k, j];
        }
        result[i, j] = sum;
    }
}

System.Console.WriteLine("Произведение Матриц:");

for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < cols2; j++)
    {
        System.Console.Write($"{result[i, j], 6}");
    }
    System.Console.WriteLine();
}
