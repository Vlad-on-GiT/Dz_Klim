// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементов массива.

double[] array = GetArray(20);
PrintArray(array);

System.Console.WriteLine($"\nРазница между максимальным и минимальным значеними в массиве равна = {DiffMinMax(array)}");

void PrintArray(double[] array)
{
    System.Console.WriteLine(string.Join(',', array));
}

double[] GetArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (999-(-999))+(-999);
        array[i] = Math.Round(array[i],2);
    }
    return array;
}

double DiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
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
    double diff = Math.Round(max - min,2);
    return diff;
}