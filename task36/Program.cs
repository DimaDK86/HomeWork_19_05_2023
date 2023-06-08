// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10,100);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


Console.WriteLine("Введите размер массива");
int massiv = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[massiv];
int sum = 0;

FillArray(numbers);
System.Console.Write("Массив - ");
PrintArray(numbers);

for (int i = 0; i < numbers.Length; i+=2)
    sum = sum + numbers[i];

System.Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях равна - {sum}");