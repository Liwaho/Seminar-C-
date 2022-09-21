/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/


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

