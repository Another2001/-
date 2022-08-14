// Показать таблицу квадратов чисел от 1 до N 
int n = 0;
Console.Write("Введите число  : ");
while (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Вводить только цифры!");
}
int d = 1;
for (int i = 1; i<=n; i++){
    d = i*i;
    Console.Write( d + " ; ");
}
