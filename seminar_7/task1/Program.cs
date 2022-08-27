// Демонстрация решения
// 1. создать массив
// 2. Заполнить массив
// 3. Печать
// 4...

int[,] CreateArray(int rows, int columns)
{
  return new int[rows, columns];
}
void Fill(int[,] array, int minValue, int maxValue)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);

  for (int row = 0; row < rows; row++)
  {
    for (int column = 0; column < columns; column++)
    {
      array[row, column] = new Random().Next(minValue, maxValue);
    }
  }
}
void Print(int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);

  for (int row = 0; row < rows; row++)
  {
    for (int column = 0; column < columns; column++)
    {
      Console.Write($"{array[row, column],5}");
    }
    Console.WriteLine();
  }
}
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
int[,] MultiplyBy(int number, int[,] array)
{
  int rows = array.GetLength(0);
  int columns = array.GetLength(1);
  int[,] result = new int[rows, columns];

  for (int row = 0; row < rows; row++)
  {
    for (int column = 0; column < columns; column++)
    {
      result[row, column] = number * array[row, column];
    }
  }
  return result;
}

void Task1()
{
  int m = Input("rows:");
  int n = Input("columns:");

  if (m >= 0 && n >= 0)
  {
    int[,] matrix = CreateArray(m, n);
    Fill(matrix, 10, 20);
    Print(matrix);
    Console.WriteLine();
    int[,] ar = MultiplyBy(10, matrix);
    Print(ar);


  }
}


Task1();
