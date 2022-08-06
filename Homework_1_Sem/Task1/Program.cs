//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//examples:
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите на проверку 2 числа:");
Console.WriteLine("1 число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("2 число: ");
int b = int.Parse(Console.ReadLine()!);
if (a > b) {
    Console.WriteLine("a = " + a + "; b = "+ b + "-> max = " + a);
}
else if (b > a){
    Console.WriteLine("a = " + a + "; b = "+ b + "-> max = " + b); 
} else {
    Console.WriteLine("chisla ravny!!" );
}
