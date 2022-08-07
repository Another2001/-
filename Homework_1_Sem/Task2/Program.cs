//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
Random rnd = new Random();

int a = rnd.Next(1, 100);
int b = rnd.Next(1, 100);
int c = rnd.Next(1, 100);
int max = a;
if (b > max){
    max = b;
}
if(c > max){
    max = c;
}
Console.Write(max);