Console.Clear();
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел."
+"Найдите среднее арифметическое элементов в каждом столбце.");
Console.Write("Введите количество строк: ");
int m= int.Parse(Console.ReadLine());

while (m <0){
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}
Console.Write("Введите количество столбцов: ");
int n= int.Parse(Console.ReadLine());

while (n <0){
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}
Console.Write("Введите минимальное значение: ");
int minValue= int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение: ");
int maxValue= int.Parse(Console.ReadLine());

int[,] RandomArray(int m, int n, int minValue, int maxValue){
    int[,]res= new int[m,n];
for(int i=0; i<m;i++){
    for(int j=0; j<n;j++){
    res[i,j]=  new Random().Next(minValue,maxValue+1 );
    }
}
return res;
}

void PrintArray(int[,] array) {
  for (int i = 0; i < array.GetLength(0); ++i) {
    for (int j = 0; j < array.GetLength(1); ++j) {
    Console.Write(array[i, j]+" ");
    }
    Console.WriteLine();
  }
}

void FindSrColums(int[,] array, int m, int n)
{
    double Sum=0;
    double SrSum=0;
    for (int i = 0; i < array.GetLength(1); ++i) 
    {
    Sum=0;
    for (int j = 0; j < array.GetLength(0); ++j) 
    { 
    Sum=Sum+array[j,i];
    }
    SrSum=Sum/m;
    Console.Write(Math.Round(SrSum,2)+" ");
    }
}
int[,] arr = new int[m,n];
arr=RandomArray(m,n, minValue, maxValue);
Console.WriteLine("Двумерный массив:");
PrintArray(arr);
Console.Write("Среднее арифметическое элементов в каждом столбце равно: ");
FindSrColums(arr,m,n);