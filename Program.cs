/*
Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

Console.Write ("Введите число №1:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число №2:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber)
{
    Console.Write("Число №1 больше числа №2");
}
else
{
    Console.Write("Число №1 меньше числа №2");
}

Напишите программу, которая принимает на вход три числа 
и выдаёт максимальное из этих чисел.


Console.Write("Введите число №1:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №2:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число №3:");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
if (secondNumber > max) max = secondNumber;
if (thirdNumber > max) max = thirdNumber;
Console.WriteLine(max);


Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

Console.Write ("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number %2 == 0)
{
    Console.Write ("Число чётное");
}
else
{
    Console.Write ("Число нечётное");
}

Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int newNumber = 1;
    while (newNumber <= number)
    {
if (newNumber %2 == 0)
{
    Console.Write (newNumber);
}
newNumber++;
    }
        
  