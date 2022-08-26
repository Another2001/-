// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// совершенно не понимаю как тут двумерные массивы привязывать к этой задаче, 
// ведь по сути даже и одномерный массив то не нужен)

Console.Write("Введите кол-во вводимых чисел : ");
int m = Convert.ToInt32(Console.ReadLine());
int CountMoreThanZero(int m)
{
    int count = 0;
    Console.Write("Наш набор чисел : ");
    for (int i = 0; i < m; i++)
    {
        int chislo = new Random().Next(-5, 10);
        Console.Write($" {chislo}");
        if (chislo > 0)
        {
            count++;
        }
    }
    Console.WriteLine("");
    return count;
}
Console.WriteLine($"Чисел больше 0 -> {CountMoreThanZero((m))}");