/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве. */

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(999);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(',', array));
}

int CountEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] array = GetArray(100);
PrintArray(array);

System.Console.WriteLine($"\n Количество четных чисел в массиве = {CountEvenNumber(array)}");