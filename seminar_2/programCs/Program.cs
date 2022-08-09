

//9. Напишите программу, которая выводит случайное число из отрезка 
//[10, 99] и показывает наибольшую цифру числа.
// 78-> 8
// 12-> 2
// 85-> 8

// ОК
void Ex01()
{
  int val = new Random().Next(10, 100);
  int a = val / 10;
  int b = val % 10;
  Console.WriteLine(val);

  if (a > b)
  {
    Console.WriteLine(a);
  }
  else
  {
    Console.WriteLine(b);
  }
}
//Ex01();



// ОК 2
int RandomInt(int min, int max)
{
  return new Random().Next(min, max);
}

void Ex02(int val)
{
  int a = val / 10;
  int b = val % 10;
  Console.WriteLine(val);
  if (a > b)
  {
    Console.WriteLine(a);
  }
  else
  {
    Console.WriteLine(b);
  }
}

//Ex02(RandomInt(10, 100));


string Ex03(int val)
{
  string result = String.Empty;
  int a = val / 10;
  int b = val % 10;
  result = Convert.ToString(val) + " ";
  if (a > b)
  {
    result = result + "max " + Convert.ToString(a);
  }
  else
  {
    result = result + "max " + Convert.ToString(b);
  }
  return result;
}

Console.WriteLine(Ex03(RandomInt(10, 100)));
