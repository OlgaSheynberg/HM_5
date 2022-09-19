Console.Clear();
Console.WriteLine("Задача 64: Задайте значения M и N."
+ "Напишите программу, которая выведет все натуральные числа в промежутке от M до N");

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());

while (m < 0)
{
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());
while (n < 0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}

while (m > n)
{
    Console.WriteLine(" введите число N больше M");
    n = int.Parse(Console.ReadLine());
}
string NaturalNum = " ";

void PrintNaturalNumber(int i, int j)
{
    if (i == j)
    {
        Console.Write(i);
        return;
    }
    if (i != j)
    {
        Console.Write(i+" ");
        PrintNaturalNumber(i+1, j);
    }
}
Console.Write("Ряд натуральных чисел: ");
PrintNaturalNumber(m, n);