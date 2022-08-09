// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
int RandomInt(int min, int max)
{
  return new Random().Next(min, max);
}
string len(){
    string result = Convert.ToString(RandomInt(5,2500));
    return result;
}
Boolean check(int str1){
    Boolean p = false;
    if ((str1) < 100 ){
        p = true;
    } 
    return p;
}
int str1 = Convert.ToInt32(len());
Console.WriteLine("Заданное число: " + str1);
if (check(str1) == true ){
    Console.WriteLine("Третьей цифры нет! ");
} else {
    Console.WriteLine("Третья цифра числа это : " + Convert.ToString(str1)[2]);
}