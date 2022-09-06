// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

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

int m = Input("Начало промежутка: ");
int n = Input("Конец промежутка: ");

int[] CreateArray()
{
    return new int[n - m + 1];
}

int[] arra = CreateArray();

void Print(int[] array)
{
    int rows = array.GetLength(0);
    for (int row = 0; row < rows; row++)
    {
        array[row] = m;
        Console.Write($"{array[row],3}");
        m++;
    }
}


Print(arra);