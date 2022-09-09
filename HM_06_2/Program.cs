Console.Clear();
Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.Write("Введите число b1: ");
double b1= double.Parse(Console.ReadLine());

Console.Write("Введите число k1: ");
double k1= double.Parse(Console.ReadLine());

Console.Write("Введите число b2: ");
double b2= double.Parse(Console.ReadLine());

Console.Write("Введите число k2: ");
double k2= double.Parse(Console.ReadLine());

if(k1==k2&& b1==b2)
{
    Console.WriteLine("Прямые совпадают");
}
if(k1==k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
double x= (b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.WriteLine("Координаты пересечения: x= "+Math.Round(x,3) +";y= "+Math.Round(y,3));
}