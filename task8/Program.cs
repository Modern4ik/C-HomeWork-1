// Поиск чётного числа в заданном пределе

Console.Write("Введите число: ");
string Number = Console.ReadLine() ?? "";
int limit = int.Parse(Number);

int numb = 1;

while (numb <= limit)
{
    if (numb%2 == 0)
        Console.WriteLine(numb);
    numb = numb + 1;
}
