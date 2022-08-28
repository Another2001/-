// Найти произведение двух матриц

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
