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
