// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

System.Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int count = 2;

while(count <= num)
{
   System.Console.Write(count);
   System.Console.Write(" ");
   count = count +2;
}
//    {
//        x = (x+xa)/2;
//        y = (y+ya)/2;
//    }

//    if(what == 1)
//    {
//        x = (x+xb)/2;
//        y = (y+yb)/2;
//    }

//    if(what == 2)
//    {
//        x = (x+xc)/2;
//        y = (y+yc)/2;
//    }

//     Console.SetCursorPosition(x, y);
//     Console.WriteLine("+");
//     count = count + 1;


// }