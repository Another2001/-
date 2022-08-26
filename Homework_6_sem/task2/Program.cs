// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(string, string) Intersection()
{
    double y1 = 0;
    double y2 = 1;
    double b1, b2, k1, k2 = 0;
    k1 = new Random().Next(-2, 3);
    b2 = new Random().Next(-2, 3);
    k2 = new Random().Next(-2, 3);
    b1 = new Random().Next(-2, 3);
    Console.WriteLine($"b1 = {b1} , b2 = {b2} , k1 = {k1} , k2 = {k2}");
    if (k1 == k2)
    {
        var result = ("при вычислении ординаты Y произошло деление на 0", " прямые параллельны");
        return result;
    }
    else
    {
        double y = (b2 - b1) / (k1 - k2);
        double x = k1 * y + b1;
        var result = (Convert.ToString(Math.Round(x, 2)), Convert.ToString(Math.Round(y, 2)));
        return result;
    }
}
var tochka = Intersection();
// если выводятся целые числа в (x: N ; y: N) , то попробуйте еще пару раз, 
// должно вывести число с знаками после зарятой ( не больше двух )
// в тетради рисовал графики, ответы сходятся (как в программе реализовать граф вывод не сообразил)
Console.WriteLine($"точка пересечения прямых : ({tochka.Item1} ; {tochka.Item2})");