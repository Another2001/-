// 16. Напишите программу, которая принимает на вход два числа и проверяет, является
//ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет
//а как корень? ++ да
//правда мы только в одной функции сделали имя не дал
// всего хорошего)
int random(){
Random rnd = new Random();
int a = rnd.Next(1, 121);  
return a;  
}
Boolean check(int y,int x){
Boolean T = false;
if ((x * x == y ) || (y * y == x)){
    T = true;
}
return T;
}
int x = random();
int y = random();
Console.WriteLine("первое число : " + x);
Console.WriteLine("второе число : " + y);
if (check(y,x) == true ){
    Console.Write("да");
}else{
  Console.Write("нет");  
}