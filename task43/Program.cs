// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

System.Console.WriteLine("Введите значение - b1");
decimal b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение - b2");
decimal b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение - k1");
decimal k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите значение - k2");
decimal k2 = Convert.ToInt32(Console.ReadLine());

decimal x = (b2 - b1)/(k1 - k2);
decimal y = k2 * x + b2;

System.Console.WriteLine($"Точка пересечения приямых линий -  X: {x}, Y: {y}");