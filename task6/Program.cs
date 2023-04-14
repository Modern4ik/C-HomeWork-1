// Определение числа на чётное или нечётное

Console.Write("Введите целое число: ");
string Number = Console.ReadLine() ?? "";
int numb = int.Parse(Number);

if (numb%2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечётное");
}