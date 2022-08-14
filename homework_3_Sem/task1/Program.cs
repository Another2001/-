/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
int chislo = 0;
Console.Write("Введите число  : ");
while (!int.TryParse(Console.ReadLine(), out chislo))
{
    Console.WriteLine("Вводить только цифры!");
}
while (chislo < 10000){
    Console.WriteLine("число должно быть 5-значным (то есть больше чем 9999)");
    int.TryParse(Console.ReadLine(),out chislo);
}
int n = chislo;
int b = 0;
while(chislo > 0){
    b = b*10+chislo % 10;
    chislo/=10;
}
Console.WriteLine("число наоборот - " + b); 
if(n == b){
    Console.WriteLine("Заданное число является палиндромом! "); 
}else{
    Console.WriteLine("Число не палиндром! ");
}




