// // сколько существует программ
// int k = 2;
// int FunctionOne(int k)
// {
//  k += 1; 
//  return k;
// }
// int FunctionTwo(int k)
// {
//  k *= 2; 
//  return k;
// }

// for (int i = 0; i < 10; i++)
// {   
//     int count = 0;
//     while (k<=7) {
// }

// }
// 2*2+1+1+1
// (2+1)*2+1
// 2+1+1+1+1+1



int func(int x, int y)
{ 
    int t = 0;
    if (x == y) t = 1 ;
    if (x > y) t = 0 ;
    if(x < y) t = func(x+1,y) + func(x*2,y);
    return t;
}
Console.WriteLine(func(2,7));
