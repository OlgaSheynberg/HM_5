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

double[,]array= new double [n,m];

  for (int i = 0; i < n; ++i) 
  {
    for (int j = 0; j < m; ++j) 
    {
      array[i, j] = new Random().Next(minValue,maxValue) +new Random().NextDouble();
    }
  }
  for (int i = 0; i < array.GetLength(0); ++i)
   {
    for (int j = 0; j < array.GetLength(1); ++j)
     {
      Console.Write(Math.Round(array[i, j],3)+" ");
    }
    Console.WriteLine();
  }