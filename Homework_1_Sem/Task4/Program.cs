// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Random rnd = new Random();
int N = rnd.Next(1, 25);
int m = 1;
Console.WriteLine("Введенное число : " + N);
while (N>m){
   m++;
   if(m %2 == 0) {
    Console.WriteLine(m);
   } 
}

