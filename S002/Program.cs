// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

int num = new Random().Next(10, 100);

int num1 = num / 10;
int num2 = num % 10;

Console.WriteLine(num); 

if (num1 > num2)
{
    Console.WriteLine($"num1 > num2 max = {num1} ");
}
else if (num1 < num2)
{
    Console.WriteLine($"num1 < num2  max = {num2} ");
}
else
{
    Console.WriteLine($"num1 == num2  max = {num1} ");
}