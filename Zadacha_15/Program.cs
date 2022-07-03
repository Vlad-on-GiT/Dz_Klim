Console.WriteLine("Введите номер дня недели: ");
int i = int.Parse(Console.ReadLine()!);

if (i > 0 && i <= 5)
{
    System.Console.WriteLine("Будни");
}
else if (i > 5 && i < 8)
{
    System.Console.WriteLine("Выходной");
}
else if (i <= 0 || i > 7)
{
    System.Console.WriteLine("Неверный номер дня");
}