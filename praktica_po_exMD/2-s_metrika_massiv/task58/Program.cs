//  Написать программу, которая в двумерном массиве заменяет строки на 
// столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
void Transporate(ref int[,] matrix)
{
    int[,] massiv = CreateArray(matrix.GetLength(0), matrix.GetLength(1));
    for (int i = 0; i <matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            massiv[j,i] = matrix[i,j];
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = massiv[i,j];
        }
    }
}
int[,] array = CreateArray(5, 5);
Fill(array, 1, 100);
Print(array);
Console.WriteLine();
Transporate(ref array);
Print(array);
