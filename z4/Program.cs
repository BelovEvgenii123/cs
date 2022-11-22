//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Напишите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите третье число");
int c = int.Parse(Console.ReadLine());
int m ;
m=a;
if (b>a)
m= b;
if (c>m)
m= c ;
Console.Write(m);
