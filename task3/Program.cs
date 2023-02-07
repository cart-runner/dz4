//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.\
int[] array = new int [8];
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"введите элемент массива {i}:\t");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine(array[i]);
}