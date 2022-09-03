// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray(int rows, int columns, int volume)
{
    return new int[rows, columns, volume];
}

void Fill(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int volume = array.GetLength(2);
    string s = string.Empty;
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            for (int volum = 0; volum < volume; volum++)
            {
                int a = new Random().Next(10, 100);
                s += $"{a},";
                //Console.WriteLine(s);
                do
                {
                    a = new Random().Next(10, 100);
                    // метод "Contains" имеет логический тип данных , принимает на вход массив(строку) и значение 
                    // для проверки, возвращая истину при нахождении в строке данного символа
                } while (s.Contains(Convert.ToString(a)));
                array[row, column, volum] = a;
                //если указать ровно 8 чисел, то значения элементов массива будут повторяться :(( 
                //как правильно сделать "неповторяющиеся" символы? 
            }
        }

    }

}

void Print(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int volume = array.GetLength(2);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            for (int volum = 0; volum < volume; volum++)
            {
                Console.WriteLine($"{array[row, column, volum]} ({row}, {column}, {volum})");
            }
        }
    }
}
Console.WriteLine("3-x мерный массив построчно с индексацией: ");
int[,,] matrix = CreateArray(2, 2, 2);
Fill(matrix);
Print(matrix);
