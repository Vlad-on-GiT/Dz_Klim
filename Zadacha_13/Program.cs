// Этот код использует число как строку, и выводит номер цифры как массив
Console.WriteLine("Введите число: ");
string i = Console.ReadLine();

if (int.Parse (i) > 99)
{ 
    Console.WriteLine(i[2]); 
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

// А этот код использует цикл, и отрезает последнюю цифру, пока число не станет короче 100
// Далее выводит результат

Console.WriteLine ("Введите трехзначное число: ");
int number = int.Parse (Console.ReadLine ()!);
int result = 0;

if (number/100 == 0)
{
    System.Console.WriteLine($"В числе {number} нет третьей цифры!");
}
else
{
    while (number/100 >= 1)
    {
    result = number % 10;
    number = number / 10;
    }
    System.Console.Write("третья цифра ");
    System.Console.WriteLine(result);
}