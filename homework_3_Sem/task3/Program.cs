//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
int l = 0;
Console.Write("Введите число для вывода кубов : ");
while (!int.TryParse(Console.ReadLine(), out l))
{
    Console.WriteLine("Вводить только цифры!");
}
int d = 1;
for (int i = 1; i<=l; i++){
    d = i*i*i;
    Console.WriteLine(i + " -> " + d);
}   

