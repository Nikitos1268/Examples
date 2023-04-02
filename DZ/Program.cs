Console.WriteLine("Putt first number");
string One = Console.ReadLine();
int numOne = Convert.ToInt32(One);
Console.WriteLine("Putt second number");
string Two = Console.ReadLine();
int numTwo = Convert.ToInt32(Two);


if ((numOne * numOne) == numTwo)
{
    Console.WriteLine("Первое число является квадратом второго");
}