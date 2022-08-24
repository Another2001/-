// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива : ");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
void GetMass(int a)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            array[i] = new Random().Next(-25, 75);
            Console.Write(" (" + array[i] + ") ");  // выделим нечетные элементы
        }
        else
        {
            array[i] = new Random().Next(-25, 75);
            Console.Write(" " + array[i] + " ");
        }

    }
}
int Sum()
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

GetMass(a);
Console.WriteLine($"Сумма нечетных элементов = {Sum()}");