Console.Clear();
Console.WriteLine("Задача 54: Задайте двумерный массив."
+ "Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

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

void MinMaxRows(int[,] array, int m, int n){
    for (int i = 0; i < m; ++i){
        int max=array[i,0];
    for (int j = 0; j < n; ++j){
            if (array[i, j] < max){
                int temp = array[i, j];
                array[i, j] = array[i, j - 1];
                array[i, j - 1] = temp;
            }
          max = array[i, j];
        } 
    }
}

int[,] arr = new int[m, n];
arr = RandomArray(m, n, minValue, maxValue);
Console.WriteLine("Двумерный массив:");
PrintArray(arr);
Console.WriteLine("Упорядоченный массив: ");
while(n>=0){
    MinMaxRows(arr, m, n);
    n--;
}
PrintArray(arr);