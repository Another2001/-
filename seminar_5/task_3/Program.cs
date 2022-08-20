// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
System.Console.WriteLine("Массив :");
int[] mas = new int[20];
int[] Insert()
{
    for (int i = 0; i < 20; i++)
    {
        mas[i] = new Random().Next(5, 105);
        Console.Write("  " + mas[i]);
    }
    return mas;
}
int min = 10;
int max = 99;
int sum = 0;
int Check()
{
    for (int i = 0; i < 20; i++)
    {
        if (min <= mas[i] &&  mas[i] <= max)
        {
            sum++;
        }
    }
    return sum;
}
Insert();
System.Console.WriteLine(" ");
System.Console.WriteLine("Количество элементов в отрезке [10,99] : " + Check());

