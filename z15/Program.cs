// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();
Console.WriteLine("Напишите число");
int a = int.Parse(Console.ReadLine());
if ((a <6) && (a!=0))
Console.WriteLine("нет");
if ((a>5) && (a<8))
Console.WriteLine("да");
if ((a>7)||(a==0))
Console.WriteLine("нет такого дня недели");