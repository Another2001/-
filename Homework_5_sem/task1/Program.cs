// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

string CheckEvenNumb(int N) // Можно было разделить на 3 функции, но кому оно надо?)) 

{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 500);
        Console.Write(" " + array[i] + " ");
    }
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)

        {
            quantity++;
        }
    }
    if (quantity == 0) return "Четных чисел нет";
    else return ($"кол-во четных чисел : {quantity}");
}

Console.Write("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CheckEvenNumb(N));
