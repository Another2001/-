/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/
Console.WriteLine("Введите кординаты точки в порядке: X Y Z -");

int vvod(){
    int p = 0;
    p = Convert.ToInt32(Console.ReadLine());
    return p;
}
(int,int,int) pointX(){
    (int x,int y,int z)point = ( vvod() ,   vvod() ,  vvod());
    return point;
}
double AB;
Console.Write("A: ");
var A = pointX();
Console.Write("B: ");
var B = pointX();
AB = Math.Sqrt((B.Item1 - A.Item1)*(B.Item1 - A.Item1)+
 (B.Item2 - A.Item2)*(B.Item2 - A.Item2)+
 (B.Item3 - A.Item3)*(B.Item3 - A.Item3));
Console.WriteLine("Расстояние между точками в 3D пространстве = " + AB
);