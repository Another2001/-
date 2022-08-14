// Возведите число А в натуральную степень B используя цикл
int A = 0;
int B = 0;
Console.WriteLine("Ввозводим число А в степень В");
Console.Write("Введите число А : ");
while (!int.TryParse(Console.ReadLine(), out A))
{
    Console.WriteLine("Вводить только цифры!");
}
Console.Write("Введите степень В : ");
while (!int.TryParse(Console.ReadLine(), out B))
{
    Console.WriteLine("Вводить только цифры!");
}
int step = A;
for (int i = 1; i<B; i++){
    Console.WriteLine("step " + i + " -> " + A);
    A = step * A;
}   
Console.Write( "step " + B + " is: " + A);

