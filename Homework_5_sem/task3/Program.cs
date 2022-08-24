// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите размер массива : ");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];
void GetMasDou(int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * 100 - 50, 2);
        Console.Write(" " + array[i] + " ");
    }
}
double Min()
{
    double mini = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < mini)
        {
            mini = array[i];
        }
    }
    return mini;
}
double Max()
{
    double maxi = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxi)
        {
            maxi = array[i];
        }
    }
    return maxi;
}
double Differ()
{
    double diff = Math.Round(Max() - Min(), 2);
    return diff;
}
GetMasDou(a);
Console.WriteLine();
Console.WriteLine($"Разница между мин. и макс. элементами массива = {Differ()}");