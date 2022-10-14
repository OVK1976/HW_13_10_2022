/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Пример решения:
a = 5; b = 7->max = 7
a = 2 b = 10->max = 10
 a = -9 b = -3->max = -3 
Уточнения: числа целые, проверка равенства значений не предусмотрена */
Console.Write("Введите число 1: ");
string a=Console.ReadLine();
Console.Write("Введите число 2: ");
string b = Console.ReadLine();
int a1=int.Parse(a);
int b1=int.Parse(b);
if (a1>b1) Console.WriteLine($"max={a1} min={b1}");
else
    Console.WriteLine($"max={b1} min={a1}");
Console.WriteLine("Расчеты завершены");