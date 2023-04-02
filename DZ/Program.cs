string One = Console.ReadLine();
string Two = Console.ReadLine();

int numOne = Convert.ToInt32(One);
int numTwo = Convert.ToInt32(Two);

if ((numOne * numOne) == numTwo)
{
    Console.WriteLine("Первое число является квадратом второго");
}