Console.Clear();
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии."
 + "Даны два неотрицательных числа m и n.");

Console.Write("Введите значение m: ");
int m = int.Parse(Console.ReadLine());

while (m < 0)
{
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}

Console.Write("Введите значение n: ");
int n = int.Parse(Console.ReadLine());
while (n < 0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        n = n + 1;
        return n ;
    }
    if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m,n-1));
    }
}
int a = Akkerman(m, n);
Console.Write("Функция Аккермана A("+m +"," +n +") =" +a);