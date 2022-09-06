int func(int x, int y)
{ 
    int t = 0;
    if (x == y) t = 1 ;
    if (x > y) t = 0 ;
    if(x < y) t = func(x+1,y) + func(x*2,y);
    return t;
}
Console.WriteLine(func(2,7));
