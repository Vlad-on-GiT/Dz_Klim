﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечетных позициях

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(',', array));
}

int SumElemOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = GetArray(20);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях индекса: {SumElemOddPosition(array)}");