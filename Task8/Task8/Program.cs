/*Задача 8: Напишите программу, которая на вход принимает число (N), 
 а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/
Console.Write("Введите число: ");
int N=int.Parse(Console.ReadLine());
Console.WriteLine($"Все четные числа от 1 до {N} :");
for (int indx = 1; indx < N; indx++)
    if (indx % 2 == 0) Console.Write($" {indx} ");