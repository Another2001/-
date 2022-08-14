// Определить количество цифр в числе
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (a > 10) {
    a /= 10;
    count++; 
}
Console.WriteLine("Цифр в заданном числе: " + count);
