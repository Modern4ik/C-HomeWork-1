// Поиск максимального числа из двух целых чисел

Console.Write("Введите первое целое число: ");
String FirstNumber = Console.ReadLine() ?? "";
int number1 = int.Parse(FirstNumber);
Console.Write("Введите второе целое число: ");
String SecondNumber = Console.ReadLine() ?? "";
int number2 = int.Parse(SecondNumber);

if (number1 > number2)
{
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine(number2);
}