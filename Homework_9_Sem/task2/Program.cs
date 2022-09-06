// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Input(string text)
{
    bool f = false;
    int number = 0;
    while (!f)
    {
        Console.Write(text);
        string str = Console.ReadLine();
        f = int.TryParse(str, out number);
    }
    return number;
}

int m = Input("Начало промежутка: ");
int n = Input("Конец промежутка: ");

int[] CreateArray()
{
    return new int[n - m + 1];
}

int[] arra = CreateArray();

void Print(int[] array)
{
    int rows = array.GetLength(0);
    int summ = 0;
    Console.Write("Заданный промежуток: ");
    for (int row = 0; row < rows; row++)
    {
        array[row] = m;
        summ += m;
        Console.Write($" {array[row],2}");
        m++;
    }
    Console.WriteLine();
    Console.WriteLine($"Cумма элементов в промежутке : {summ}");
}

Print(arra);