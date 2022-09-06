// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Ackerman(int M, int N)
{
    if (N == 0)
    {
        return M + 1;
    }
    int result = M;
    for (int i = 0; i < M + 2; i++)
    {
        result = Ackerman(N - 1, result);
    }
    return result;
}
Console.WriteLine(Ackerman(2, 3));

// Stack overflow.
// Repeat 19264 times:
// 