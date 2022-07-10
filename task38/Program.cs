//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

System.Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];
System.Console.WriteLine("Заполненный случайными числами массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1000);
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();

double amax = array[0];
double amin = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i]> amax)
    {
        amax = array [i];
    }
     if (array[i] < amin)
    {
        amin = array [i];
    }
}
System.Console.WriteLine("Максимальный элемент массива: " + amax);
System.Console.WriteLine("Минимальный элемент массива: " + amin);
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива равна: " + (amax - amin));