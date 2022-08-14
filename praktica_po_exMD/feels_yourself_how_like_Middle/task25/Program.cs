//Найти сумму чисел от 1 до А
int A = 0;
Console.Write("Введите число  : ");
while (!int.TryParse(Console.ReadLine(), out A))
{
    Console.WriteLine("Вводить только цифры!");
}
int sum = 0;
for (int i = 1; i<=A; i++){
    sum = sum + i;
}   
Console.Write( "sum is : "+sum);


