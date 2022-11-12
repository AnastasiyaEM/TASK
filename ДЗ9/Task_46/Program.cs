// Найти сумму элементов от M до N, N и M заданы

int Sum(int M, int N)
{
    if (N == M) return 0; // возможность рекурсивного выхода
    else if (N > M) return N + Sum(M,N -1);
    return Sum(M,N);
}


Console.WriteLine(" Введите число M (от)");
int M = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(" Введите число N (до)");
int N = int.Parse(Console.ReadLine() ?? "0");
int sum = Sum(M,N);
Console.WriteLine($"Сумма элементов от M до N: ");
Console.WriteLine(sum);