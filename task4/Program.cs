// Поиск максимального числа из трёх 

Console.Write("Введите первое целое число: ");
string FirstNumber = Console.ReadLine() ?? "";
int number1 = int.Parse(FirstNumber);

Console.Write("Введите второе целое число: ");
string SecondNumber = Console.ReadLine() ?? "";
int number2 = int.Parse(SecondNumber);

Console.Write("Введите третье целое число: ");
string ThirdNumber = Console.ReadLine() ?? "";
int number3 = int.Parse(ThirdNumber);

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine(max);

