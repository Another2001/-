// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

string ColumnsSum(int[,] array)
{
    string summa = string.Empty;
    int sum = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        sum = 0;
        for (int col = 0; col < array.GetLength(1); col++)
        {
            sum += array[col, row];
        }
        summa += sum + "   ";
    }
    return summa;
}

int m = Input("кол - во строк: ");
int n = Input("кол - во стобиков: ");

if (m >= 0 && n >= 0)
{
    int[,] matrix = CreateArray(m, n);
    Fill(matrix, 5, 15);
    Print(matrix);
    Console.WriteLine("Cумма столбцов ");
    Console.WriteLine("   " + ColumnsSum(matrix));
}