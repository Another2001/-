// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int[,] CreateMatrix(int rows, int columns)
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

int[,] Update(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[,] result = new int[rows, columns];

    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            if (column % 2 == 0 && row % 2 == 0)
            {
                result[row, column] = array[row, column];
                result[row, column] *= result[row, column];
            }
            else
            {
                result[row, column] = array[row, column];
            }
        }
    }
    return result;
}
int m = Input("rows:");
int n = Input("columns:");
int[,] matrix = CreateMatrix(m, n);
Fill(matrix, 10, 20);
Print(matrix);
int[,] ar = Update(matrix);
Console.WriteLine();
Print(ar);
