// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
//
//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница
double a,b;
Console.WriteLine("Vvedite na proverku 2 chisla:");
Console.WriteLine("1 chislo: ");
Console.Readline(a);
Console.WriteLine("2 chislo: ");
Console.Readline(b);
if (a==b*b) {
Console.WriteLine("da"); //, pervoe chislo -" + a + "yavlyaetsya kvadratom vtorogo chisla -  + b
}
else {
Console.WriteLine("net"); //, pervoe chislo -" + a + "yavlyaetsya kvadratom vtorogo chisla - " + b  
}
