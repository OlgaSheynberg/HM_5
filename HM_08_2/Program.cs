Console.Clear();
Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив."
+ "Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

while (m < 0)
{
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

while (n < 0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}
Console.Write("Введите минимальное значение: ");
int minValue = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine());

int[,] RandomArray(int m, int n, int minValue, int maxValue)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return res;
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
/* 
 void RowsSum(int[,] array, int m, int n) 
{
    int sum=0; 
    for (int i = 0; i < m; ++i)
    {
       sum=0;
        for (int j = 0; j < n; ++j)
        {
            sum = sum + array[i, j];
        }
    Console.Write(sum + " ");
    }
} 
 */

int[] RowsSum1(int[,] array, int m, int n)
{
    int[] sum=new int[n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            sum[i] = sum[i] + array[i, j];
        }
    }
Console.WriteLine(string.Join(", ", sum));
return sum;
}

int[] RowsSum2(int[,] array, int m, int n)
{
    int[] sum=new int[n];
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            for(int k=0; k<n; ++k)
            {
            sum[i] = sum[i] + array[i, j];
            }
        }
    }
Console.WriteLine(string.Join(", ", sum));
return sum;
}

int[,] arr = new int[m, n];
arr = RandomArray(m, n, minValue, maxValue);
Console.WriteLine("Двумерный массив:");
PrintArray(arr);
//Console.WriteLine("Сумма элементов каждой строки: ");
//RowsSum(arr, m, n);

Console.WriteLine("Сумма элементов каждой строки: ");
int[] sum=RowsSum1(arr, m, n);
int[] sum2=RowsSum2(arr, m, n);

    int min=sum[0];
    int imin=0; 
for (int i=0; i<n;i++)
{

    if(sum[i]<min)
    {
        min=sum[i];
        imin=i;
    }
}
Console.WriteLine("строки" +imin);
