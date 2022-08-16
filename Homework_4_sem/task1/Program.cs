// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine("Введите сначала число, затем степень: ");
int GetStep(int A,int B){
    int step = A;
    System.Console.WriteLine("|--------|");
    for (int i = 0; i < B-1; i++)
    {
        step *= A;
        System.Console.WriteLine(i + 2 + " степень - " + step);
    }
return step;
}
Console.Write($" число в степени  это: {GetStep(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()))}");



