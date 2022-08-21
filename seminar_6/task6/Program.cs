// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
int[,] Fill(int m, int n)
{
    int[,] arr = new int [m,n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i+j;
            
        }
    }
    return arr;
}
System.Console.Write("Введите число для проверки : ");
int Chi = Convert.ToInt32(Console.Readline());
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
int Check(){

}

Fill(5,4);
Print(Fill(5,4));
Check();