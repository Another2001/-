// Задача 32: Напишите функцию замена элементов массива: положительные элементы 
//замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
Console.Write("Введите размер массива : ");
int N = Convert.ToInt32(Console.ReadLine());
int[] mas = new int[N];
int[] Inverse(int N)
{
    
    for (int i = 0; i < N; i++)
    {
        mas[i] = new Random().Next(-20, 21);
        Console.Write("  " + mas[i]);
    }
    Console.WriteLine(" ");
    Console.WriteLine("обратный массив : ");
    for (int i = 0; i < N; i++)
    {
        mas[i] *= -1;
        Console.Write("  " + mas[i]);
    }
    return mas;
}
Inverse(N);
