// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
int random(){
Random rnd = new Random();
int a = rnd.Next(100, 999);  
return a;  
}
int a = random();
Console.WriteLine("Наше число : " + a );
int secoNum(){
   int x = a / 10;
   x = x % 10;
return x;
}
Console.WriteLine("Вторая цифра 3-х значного числа : " +secoNum());