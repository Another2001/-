﻿// 1. Напишите метод, которая возвращает массив из N элементов, заполненный нулями и единицами в случайном порядке.
/*
N = 3 => [1, 0, 0]
N = 8 => [1,0,1,1,0,1,0,0]

2. написать метод, который принимает на вход
двоичное представление числа в виде массива ARR и выдаёт десятичное представление

ARR = [1, 0, 0] => 4
ARR = [1,0,1,1,0,1,0,0] => 180

3. написать метод, который принимает на вход
десятичное представление числа N и показатель основания СС P, в котороую
нужно перевести это число

N = 31, P = 2 => 11111
N = 31, P = 8 => 37

ДОГОВОРИМСЯ, что  2<= p <= 9*/

// 1.Напишите метод, который возвращает массив из N элементов, 
// заполненный нулями и единицами в случайном порядке.

// N = 3 => [1, 0, 0]
// N = 8 => [1,0,1,1,0,1,0,0]

int[] GetBinaryArray(int n)
{
  int[] arr = new int[n];
  for (int i = 0; i < n; i++)
  {
    arr[i] = new Random().Next(0, 2);
  }
  return arr;
}

void Print(int[] arr)
{
  int size = arr.Length;
  for (int i = 0; i < size; i++)
  {
    System.Console.Write(arr[i]);
  }
}

string NewPrint(int[] arr)
{
  string s = String.Empty;
  int size = arr.Length;
  for (int i = 0; i < size; i++)
  {
    s += Convert.ToString(arr[i]);
  }
  return s;
}


// 2.написать метод, который принимает на вход
// двоичное представление числа в виде массива ARR и выдаёт
// десятичное представление

// ARR = [1, 0, 0] => 4
// ARR = [1, 0, 1, 1, 0, 1, 0, 0] => 180

double BinToDec(int[] arr)
{
  // 3210
  // 1101
  // 0123
  double res = 0;
  int size = arr.Length;
  for (int i = 0; i < size; i++)
  {
    res += arr[i] * Math.Pow(2, size - 1 - i);
  }
  return res;
}

// // Клиентский код
int[] res = GetBinaryArray(4);
Print(res);

string s = NewPrint(res);
Console.WriteLine($"s: {s}");
Console.ReadLine();
double dec = BinToDec(res);
Console.WriteLine($"dec: {dec}");

// 3.написать метод, который принимает на вход
// десятичное представление числа N и показатель основания СС P, в которую
// нужно перевести это число

// N = 31, P = 2 => 11111
// N = 31, P = 8 => 37

// ДОГОВОРИМСЯ, что  2<= p <= 9

int[] DecToP(int dec, int p)
{

  int size = 5;
  int[] res = new int[size + 1];


  while (dec != 0)
  {
    int o = dec % p;
    dec = dec / p;
    res[size] = o;
    size--;
  }


  return res;
}

// // Клиентский код
// int[] res = GetBinaryArray(4);
// //Print(res);

// string s = NewPrint(res);
// Console.WriteLine($"s: {s}");
// Console.ReadLine();
// double dec = BinToDec(res);
// Console.WriteLine($"dec: {dec}");

int[] resP = DecToP(234, 9);
Console.WriteLine($"NewPrint: {NewPrint(resP)}");
;

