//1. 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98
int random(){
Random rnd = new Random();
int a = rnd.Next(100, 999);  
return a;  
}
int razdel(int a){
int x = a%10;
int y = a/100;  
return y*10+x;  
}
void vivod(int a,int z){
Console.WriteLine(" случайное число : " + a);
Console.WriteLine(z);    
}
int a = random();
int z = razdel(a);
vivod(a,z);
