Console.Clear();
Console.WriteLine("Задача 66: Задайте значения M и N."
 +"Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");

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
//1 2 3 4 5
void SumNaturalNumber(int i, int j, int sum)
{
    if (i == j)
    {   sum+=i;
        Console.Write(sum);
        return;
    }
    if (i != j)
    {   sum+=i;
        SumNaturalNumber(i+1, j,sum);
    }
}
int sum=0;
Console.Write("Сумма натуральных чисел от M до N: ");
SumNaturalNumber(m, n,sum);