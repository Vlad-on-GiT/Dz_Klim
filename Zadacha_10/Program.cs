Console.WriteLine ("Введите трехзначное число: ");
int i = int.Parse (Console.ReadLine ()!);

System.Console.WriteLine("Вторая цифра этого числа: " + (i / 10) % 10);

// Или так можно
string stringNumber = Convert.ToString(i);
Console.WriteLine("Вторая цифра этого числа: "+stringNumber[1]);