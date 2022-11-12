// Написать программу возведения числа А в целую стень B

int Power(int A, int B)
{
    if (B == 0) return 1;
    else return Power(A, B - 1) * A;
}

int ReadIntegerNumber(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "0");
}

int A = ReadIntegerNumber("Введите число А: ");
int B = ReadIntegerNumber("В какую степень возвести число А: ");

Console.WriteLine(Power(A,B));
