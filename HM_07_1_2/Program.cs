Console.Clear();
Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");
Console.Write("Введите количество строк: ");
int m= int.Parse(Console.ReadLine());

while (m <0)
{
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}

Console.Write("Введите количество столбцов: ");
int n= int.Parse(Console.ReadLine());

while (n <0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}

Console.Write("Введите минимальное значение: ");
int minValue= int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int maxValue= int.Parse(Console.ReadLine());


int[,] GetArray(int m, int n, int minValue, int maxValue) 
{
  int[,] result = new int[m, n];

  for (int i = 0; i < m; ++i) 
  {
    for (int j = 0; j < n; ++j) 
    {
      result[i, j] = new Random().Next(minValue, maxValue + 1);
    }
  }
  return result;
}

void PrintArray(int[,] array) 
{
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
      Console.Write(array[i, j]);
    }
    Console.WriteLine();
  }
}
GetArray(m,n, minValue, maxValue);
PrintArray(array[i, j]);