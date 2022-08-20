// Задача 33: Задайте массив. Напишите функцию, которая определяет, 
//присутствует ли заданное число в массиве.
//решать без встроенных функций
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите число : ");
int Check = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива : ");
int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];
bool CheckNumb()
{
    for (int i = 0; i < N; i++)
    {
        mas[i] = new Random().Next(0, 10);
        Console.Write("  " + mas[i]);
    }
    Console.WriteLine(" ");
    bool t = false;
    for (int i = 0; i < N; i++)
    {
        if (mas[i] == Check)
        {
           t = true;
        }
    }
    return t;
}
if (CheckNumb()){
    System.Console.WriteLine("Такое число есть в массиве! ");
} else {
    System.Console.WriteLine("Такого числа нет! ");
}

