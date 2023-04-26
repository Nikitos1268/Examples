int programm;
Boolean begin = true;

int[] arrayInt = { };

while (begin)
{
    Console.WriteLine("------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
    Console.WriteLine("1.\t Вывести все натуральные числа в промежутке от M до N.");
    Console.WriteLine("2.\t Найти сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("3.\t Вычислить функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

    programm = Convert.ToInt32(Console.ReadLine());

    switch (programm)
    {
        case 1:
            CaseProgramm1();
            break;

        case 2:
            CaseProgramm2();
            break;

        case 3:
            CaseProgramm3();
            break;

        default:
            begin = false;
            break;
    }
}

//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
void CaseProgramm1()
{
    int M, N;
    Console.Write("Введите начальное значение M: ");
    M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение N: ");
    N = Convert.ToInt32(Console.ReadLine());

    void PrintRange(int start, int end)
    {
        if (end > start)
        {
            PrintRange(start, end - 1);
            Console.Write(", ");
        }
        Console.Write(end);
    }
    PrintRange(M, N);
    Console.WriteLine();
    WaitingToAnyKey();
}

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
void CaseProgramm2()
{
    int M, N;
    Console.Write("Введите начальное значение M: ");
    M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение N: ");
    N = Convert.ToInt32(Console.ReadLine());

    int SumRange(int start, int end)
    {
        int sum = 0;
        if (start < end) sum = start + end + SumRange(start + 1, end - 1);
        else if (start == end) sum = end;
        return sum;
    }
    Console.WriteLine(SumRange(M, N));
    WaitingToAnyKey();
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
void CaseProgramm3()
{
    int m, n;
    Console.Write("Введите начальное значение m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конечное значение n: ");
    n = Convert.ToInt32(Console.ReadLine());

    int Akkerman(int m, int n)
    {
        if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
        return n + 1;
    }
    Console.WriteLine(Akkerman(m, n));
    WaitingToAnyKey();
}

void WaitingToAnyKey()
{
    Console.Write("--> Нажмите любую кнопку <--");
    Console.ReadKey();
    Console.WriteLine();
}