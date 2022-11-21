Console.Clear();
Console.WriteLine("Напишите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Напишите второе число");
int b = int.Parse(Console.ReadLine());
if (a>=b)
{
Console.Write("max="+ a);
Console.Write("min="+ b);
}
else 
Console.Write("max="+ b);
Console.Write("mmin="+ a);