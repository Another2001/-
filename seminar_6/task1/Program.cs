// Показать двумерный массив размером m×n заполненный целыми числами
int[,] Fill(int m, int n)
{
    int[,] arr = new int [m,n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 25);
            
        }
    }
    return arr;
}
int[,] Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           System.Console.Write($"{arr[i,j]}, ");
        }
        System.Console.WriteLine(); 
    }
    return arr;
}
Fill(5,4);
Print(Fill(5,4));