// Напишите программу, которая задает массив из некоторого количества
// элементов и выводит их на экран с помощью функций

System.Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

int[] CreateArray(int a)
{
    for (int i = 0; i < a; i++)
    {
        System.Console.WriteLine($"\nВведите элемент массива № {i + 1}");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void ShowArray()
{
System.Console.Write("\nМассив: ");
for (int i = 0; i < size; i++)
{
    System.Console.Write($"{array[i]},");
}
}

CreateArray(size);
ShowArray();

System.Console.WriteLine("\b \b");