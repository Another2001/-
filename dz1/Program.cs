// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//a = 25, b = 5 -> да 
//a = 2, b = 10 -> нет 
//a = 9, b = -3 -> да 
//a = -3 b = 9 -> нет
//
//3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//	3 -> Среда 
//5 -> Пятница

Console.WriteLine("Введите на проверку 2 числа:");
Console.WriteLine("1 число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b*b) {
Console.WriteLine("Да! "); //, pervoe chislo -" + a + "yavlyaetsya kvadratom vtorogo chisla -  + b
}
else {
Console.WriteLine("Нет! "); //, pervoe chislo -" + a + "yavlyaetsya kvadratom vtorogo chisla - " + b  
}
