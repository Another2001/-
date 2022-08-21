// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] Fill(int m, int n)
{
    int[,] arr = new int [m,n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            
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
            if (i % 2 == 0 && j % 2 == 0 && i!= 0 && j!= 0) System.Console.Write($"|{arr[i,j] * arr[i,j]}|, ");
            else System.Console.Write($"{arr[i,j]}, ");
        }
        System.Console.WriteLine(); 
    }
    return arr;
}

Fill(5,4);
Print(Fill(5,5));

/* 0 1 2 3
 0
 1     
 2   +   +
 3               */