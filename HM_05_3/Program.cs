Console.Clear();
Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("Введите размер массива: ");
int n =int.Parse(Console.ReadLine()); 
while (n <0)
{
    Console.WriteLine(" введите положительное число");
    n = int.Parse(Console.ReadLine());
}
double[]array= new double[n];
Random rand = new Random();
for(int i=0; i<n; i++)
{
array[i] = rand.Next(0, 10) + rand.NextDouble();

}
Console.WriteLine(string.Join(", ", array));

double diff=0;
double max=array[0];
double min=array[0];
for(int i=0; i<n; i++)
{
if(array[i]>max)max=array[i];
if(array[i]<min)min=array[i];
diff=max-min;
}
Console.WriteLine("Разница между максимальным и минимальным элементами массива равна: "+ diff);