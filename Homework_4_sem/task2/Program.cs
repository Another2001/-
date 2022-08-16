// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число : ");

Int64 GetNumb(Int64 numb)
{
    return numb;
}

Int64 d = GetNumb(Convert.ToInt64(Console.ReadLine()));
Console.WriteLine($"Введенное число : {d}");

Int64 Sum()
{
    Int64 s = 0;
    while(d > 0)
    {
        s = s + d % 10;
        d /= 10;
    }
    return s;
}
 
Console.WriteLine($"Сумма цифр = {Sum()}");