//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Напишите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int b = int.Parse(Console.ReadLine());
while (a==b)
{
   Console.WriteLine("Числа равны, введите заново") ;
Console.WriteLine("Напишите первое число");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
b = int.Parse(Console.ReadLine());
}
if (a>=b)
{
Console.Write("max="+ a);
Console.Write("min="+ b);
}
else 
{
Console.Write("max="+ b);
Console.Write("mmin="+ a);
}