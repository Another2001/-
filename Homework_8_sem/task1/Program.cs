// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
int[,] Sorting(int[,] array)
{
    int min = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        min = array[row,0];
        for (int col = 0; col <= array.GetLength(1) - 1; col++)
        {
            if (array[row, col] > min)
            {
                min = array[row, col];
                (array[row, col ], array[row, col + 1]) = (array[row, col + 1], array[row, col]);   
            }
            Console.Write($"{array[row, col],5} ");
        }
        Console.WriteLine();
    }
    return array;
}


int m = Input("rows:");
int n = Input("columns:");

if (m >= 0 && n >= 0)
{
    int[,] matrix = CreateArray(m, n);
    Fill(matrix, 10, 20);
    Print(matrix);
    Console.WriteLine();
    Sorting(matrix);
}