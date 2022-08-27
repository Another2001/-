// вывести все множители каждого числа от 1 до N
Console.Write("введите количество чисел для определения: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    Console.Write($"число: {i} делители - ");
    for (int j = 1; j <= N; j++)
    {
        if (i % j == 0)
        {
            Console.Write($" {j}; ");
        }
    }
    Console.WriteLine();
}