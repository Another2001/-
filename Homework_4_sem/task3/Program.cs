// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
Console.Write("Задаем размер массива = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вводим значения элементов массива: ");
int[] TakeMas()
{
  int[] arr = new int[n];
  for (int i = 0; i < n; i++)
  {
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
  return arr;
}

string Print(int[] vat)
{
  string s = String.Empty;
  int size = vat.Length;
  for (int i = 0; i < size; i++)
  {
    if (i+1 == size) // убираем запятую после последнего элемента массива
    {
        s += Convert.ToString(vat[i]);
    } else {
        s += Convert.ToString(vat[i]) + " , "; 
    }
  }
  return s;
}

int[] res = TakeMas();
Console.WriteLine($"Ваш массив: [{Print(res)}]"); 
