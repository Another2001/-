// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1, 7] -> такого числа в массиве нет

int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int count = 0;
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            count++;
            array[row, column] = count;
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
            Console.Write($"{array[row, column],3}");
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
void FindForIndex(int[,] array, int row, int column)
{
    int r = array.GetLength(0);
    int c = array.GetLength(1);
    if (row > r || column > c)
    {
        Console.WriteLine("такого элемента нет!");
    }
    else if (row <= r || column <= c)
    {
        Console.Write("выбранный элемент массива: ");
        Console.WriteLine(array[row - 1, column - 1]);
    }
}
Console.WriteLine("размеры матрицы: ");
int m = Input("кол-во строк: ");
int n = Input("кол-во столбцов: ");
int[,] matrix = CreateArray(m, n);
if (m >= 0 && n >= 0)
{
    Fill(matrix);
    Print(matrix);
}
Console.WriteLine("позиция элемента: ");
int row = Input("строка:");
int column = Input("столбик:");
FindForIndex(matrix, row, column);