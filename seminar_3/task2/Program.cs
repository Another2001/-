// Напишите программу, которая принимает на вход координаты точки (X и Y),
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// условие "И" условие (да, только при выполнение обоих)

Console.Write("Значение Х : ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение Y : "); 
int x = Convert.ToInt32(Console.ReadLine());
if (x < 0 && y < 0){
 Console.WriteLine("точка в плоскости 4");
} else if (x > 0 && y < 0){
     Console.WriteLine("точка в плоскости 3");
} else if (x < 0 && y > 0){
     Console.WriteLine("точка в плоскости 1");
} else if (x > 0 && y > 0){
     Console.WriteLine("точка в плоскости 2");
}

