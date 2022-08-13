// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,2
//AB = √(xb - xa)2 + (yb - ya)2
Console.Write("Введите координаты точки а: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки b: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
double AB = Math.Sqrt(((y - x)*(y - x)) + ((y1 - x1)*(y1 - x1)));    
Console.Write("расстояние между 2 точек = " + AB);




