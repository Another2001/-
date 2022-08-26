// pадача со звездочкой
// ***Написать алгоритм поворота матрицы [N;N] на 90 градусов

Console.Write("Введите размерность матрицы :");
int N = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[N, N];
int[,] firstmat = new int[N, N];

int[,] CreateMatrix(int[,] matrix)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($" {matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    return matrix;
}

firstmat = matrix;

int[,] RotateMatLeft(int[,] matrix)
{
    for (int j = firstmat.GetLength(1) - 1; j >= 0; j--)
    {
        for (int i = 0; i < N; i++)
        {
            Console.Write($" {firstmat[i, j]} ");
        }
        Console.WriteLine();
    }
    return firstmat;
}

int[,] RotateMatRight(int[,] matrix)
{
    for (int j = 0; j < N; j++)
    {
        for (int i = firstmat.GetLength(0) - 1; i >= 0; i--)
        {
            Console.Write($" {firstmat[i, j]} ");
        }
        Console.WriteLine();
    }
    return firstmat;
}
int[,] TurnOverMat(int[,] matrix)                                  //переворачиваем
{
    for (int i = firstmat.GetLength(0) - 1; i >= 0; i--)
    {
        for (int j = firstmat.GetLength(1) - 1; j >= 0; j--)
        {
            Console.Write($" {firstmat[i, j]} ");
        }
        Console.WriteLine();
    }
    return firstmat;
}

CreateMatrix(matrix);
Console.WriteLine("повернутая налево матрица  : ");
RotateMatLeft(firstmat);
Console.WriteLine("повернутая направо матрица  : ");
RotateMatRight(firstmat);
Console.WriteLine("перевернутая матрица  : ");
TurnOverMat(firstmat);