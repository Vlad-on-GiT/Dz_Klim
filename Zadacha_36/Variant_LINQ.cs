// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечетных позициях
// Надеюсь так будет достаточно неординарно? ))

int[] array = GetRandomArray(10);

int[] arrayOddPosition = array
   .Where((item, index) => index % 2 != 0)
   .ToArray();

int sum = arrayOddPosition.Sum();

System.Console.WriteLine("Массив случайных чисел:");
System.Console.WriteLine(string.Join(',', array));
System.Console.WriteLine($"\nСумма чисел на нечётных позициях индекса: {sum}");

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100);
    }
    return array;
}