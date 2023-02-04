//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
/*
Console.Write("Input a first number");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second numbe");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1<number2)
{
    Console.Write("min"+number1);
}
else
{
    Console.Write("min"+number2);
}
*/
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.Write("Input number1");
int number1 = Convert.ToInt32(Console.RedLine());
Console.Write("Intput number2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number3");
int number3 = Convert.ToInt32(Console.Redline());
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка)
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int reS = number % 2;

if(reS == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N
/*
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}
*/