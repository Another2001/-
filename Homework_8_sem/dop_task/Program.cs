// ** Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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

int[,] Multiply(int[,] firMat, int[,] secMat, int[,] resMat)
{
    for (int i = 0; i < resMat.GetLength(0); i++)
    {
        for (int j = 0; j < resMat.GetLength(1); j++)
        {
            int summ = 0;
            for (int k = 0; k < firMat.GetLength(1); k++)
            {
                summ += firMat[i, k] * secMat[k, j];
            }
            resMat[i, j] = summ;
        }
    }
    return resMat;
}
int m = Input("строки 1 матрицы: ");
int n = Input("столбцы 1 матрицы: ");

int m1 = Input("строки 2 матрицы:");
int n1 = Input("столбцы 2 матрицы: ");

int[,] firMat = CreateArray(m, n);
Fill(firMat, 1, 5);
Print(firMat);

Console.WriteLine();

int[,] secMat = CreateArray(m1, n1);
Fill(secMat, 1, 5);
Print(secMat);

Console.WriteLine();

int[,] resMat = CreateArray(m, n1);
Multiply(firMat, secMat, resMat);
Print(resMat);