// Показать двумерный массив размером m×n заполненный вещественными числами
double[,] Fill(int m, int n)
{
    double[,] arr = new double [m,n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(new Random().NextDouble()*100,2);
            
        }
    }
    return arr;
}
double[,] Print(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           System.Console.Write($"{arr[i,j]} ; ");
        }
        System.Console.WriteLine(); 
    }
    return arr;
}
Fill(5,4);
Print(Fill(5,4));

