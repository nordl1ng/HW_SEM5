// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


System.Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
System.Console.WriteLine("Заполненный случайными числами массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine($"Количество четных элементов в массиве равно {count}");