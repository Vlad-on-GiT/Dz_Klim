// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

int[] array = GetArray(20);
PrintArray(array);

System.Console.WriteLine($"\nРазница между максимальным и минимальным значеними в массиве равна = {DiffMinMax(array)}");

void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(',', array));
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-999, 999);
    }
    return array;
}

int DiffMinMax(int[] array)
{
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    int diff = max - min;
    return diff;
}