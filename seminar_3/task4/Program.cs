﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,2
//AB = √(xb - xa)2 + (yb - ya)2
/*Console.Write("Введите координаты точки а: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки b: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
double AB = Math.Sqrt(((y - x)*(y - x)) + ((y1 - x1)*(y1 - x1)));    
Console.Write("расстояние между 2 точек = " + AB);*/

int n = 0, m = 0 , n1 = 0 , m1 = 0, p = 0;
int vvod(){
p = Convert.ToInt32(Console.ReadLine());
return p;
}
var cortezh = (n = vvod(), n1 = vvod() );
var cortezh1 = ( m = vvod(),m1 = vvod() );
var dlina = Math.Sqrt((cortezh.Item2 - cortezh.Item1)+(cortezh1.Item2 - cortezh1.Item1));
Console.WriteLine("расстояние между 2 точек = " + dlina);

//следующая
int l = 6;
int d = 1;
for (int i = 1; i<=l; i++){
    d = i*i;
    Console.Write( d + " ; ");
}