Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.Write("Введите число M: ");
int m= int.Parse(Console.ReadLine());

while (m <0)
{
    Console.WriteLine(" введите положительное число");
    m = int.Parse(Console.ReadLine());
}
string n="";
int CountPositive=0;
for(int count=0; count<m; count++)
{
    Console.Write("Введите число: ");
    int result = int.Parse(Console.ReadLine());
    n=n+result;
    if(result>0)
    {
    CountPositive++;
    }
}
Console.WriteLine("Количество положительных чисел: "+CountPositive);