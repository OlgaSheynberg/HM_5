Console.Clear();
Console.WriteLine("Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");

Console.Write("Введите размерстороны массива: ");
int n = int.Parse(Console.ReadLine());

while (n < 0)
{
    Console.WriteLine("Введите количетво стобцов массива");
    n = int.Parse(Console.ReadLine());
}
/* Console.Write("Введите высоту массива: ");
int n = int.Parse(Console.ReadLine());
while (n < 0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
} */

Console.Write("Введите минимальное значение массива: ");
int minValue = int.Parse(Console.ReadLine());

int k = 1;
int l = 0;
int i = 0;
int j = 0;
int[,] array = new int[n, n];
int m=n*n;
array[0,0]=minValue-1;

while (k <= m)
{
    for (i = l; i < n; i++)
    {
        array[j, i] =  array[0,0]+k;
        k++;
    }
    j = i - 1;
    for (i = l + 1; i < n; i++)
    {
        array[i, j] =array[0,0]+ k;
        k++;
    }
    for (i = n - 2; i >= l; i--)
    {
        array[j, i] = array[0,0]+k;
        k++;
    }
    j = l;
    for (i = n - 2; i > l; i--)
    {
        array[i, j] =array[0,0]+ k;
        k++;
    }
    n--;
    l++;
    j = l;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); ++i)
    {
        for (int j = 0; j < array.GetLength(1); ++j)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine();
PrintArray(array);