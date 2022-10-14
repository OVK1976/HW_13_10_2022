/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Пример
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
Уточнения: числа целые*/
Console.Write("Введите число 1: ");
string a = Console.ReadLine();
Console.Write("Введите число 2: ");
string b = Console.ReadLine();
Console.Write("Введите число 3: ");
string c = Console.ReadLine();
Console.WriteLine($"Результаты выбора максимального из чисел: {a} {b} {c}");
int a1 = int.Parse(a);
int b1 = int.Parse(b);
int c1 = int.Parse(c);
int max = a1;
if (a1 > max) max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;
Console.WriteLine($"max={max}");
Console.WriteLine("Расчеты завершены");