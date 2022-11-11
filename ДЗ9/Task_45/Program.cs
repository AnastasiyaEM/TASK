// Показать натуральные числа от M до N, N и M заданы

string NaturNumber(int N, int M)
{
    if (N>=M) return NaturNumber(N -1, M) + $"{N} ";
    else return " ";
}
 

Console.WriteLine(" Введите число M (от)");
int M = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine(" Введите число N (до)");
int N = int.Parse(Console.ReadLine()?? "0");
Console.WriteLine($" Натуральные числа: {NaturNumber(N,M)}");
