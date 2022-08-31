// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill(int[,] array, int minValue, int maxValue)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            array[row, column] = new Random().Next(minValue, maxValue);
        }
    }
}
void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column],5}");
        }
        Console.WriteLine();
    }
}
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
(int, int) RowsSum(int[,] array)
{
    int X = 0;
    int maxsum = 0;
    int sum = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        sum = 0;
        for (int col = 0; col < array.GetLength(1); col++)
        {
            sum += array[row, col];
        }
        if (sum > maxsum)
        {
            X = row;
            maxsum = sum;
        }
    }
    return (maxsum, +X);
}

int m = Input("кол - во строк: ");
int n = Input("кол - во стобиков: ");

if (m >= 0 && n >= 0)
{
    int[,] matrix = CreateArray(m, n);
    Fill(matrix, 5, 15);
    Print(matrix);
    Console.WriteLine("Cумма строки " + RowsSum(matrix).Item1 + ", номер строки с макс. суммой: " + (RowsSum(matrix).Item2 + 1));
}