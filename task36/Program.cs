// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

System.Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
System.Console.WriteLine("Заполненный случайными числами массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-1000, 1000);
    System.Console.Write($"{array[i]} ");
}
System.Console.WriteLine();
int summ = 0;
for (int i = 0; i < array.Length; i++)
{
    if (!(i % 2 == 0))
    {
        summ = summ + array[i];
    }
}
System.Console.WriteLine();
System.Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна {summ}");