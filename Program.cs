/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("Большее: " + n1 + ", меньшее: " + n2);
}
else
{
    Console.WriteLine("Большее: " + n2 + ", меньшее: " + n1);
}
/*

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
/*
Console.WriteLine("Введите первое число: ");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int n3 = int.Parse(Console.ReadLine());
if (n1 > n2)
{
    if (n1 > n3)
    {
        Console.WriteLine("Большее: " + n1);
    }
    else
    {
        Console.WriteLine("Большее: " + n3);
    }
}
else if (n2 > n1)
{
   if (n2 > n3)
   {
        Console.WriteLine("Большее: " + n2);
   }   
}
else
{
    Console.WriteLine("Первое и второе число равны.");
}
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/
/*
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Четное число");
}

if (number != 0);
{
    Console.WriteLine("Нечетное число");
}
*/

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int a = 0;
while (a <= number)
{
    if (a % 2 == 0)
    {
        Console.Write(a + " ");
    }
    a = a + 1;
}
