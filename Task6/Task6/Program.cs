/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Пример:
4 -> да
-3 -> нет
7 -> нет */
Console.Write("Введите число: ");
string a = Console.ReadLine();
int a1 = int.Parse(a);
if (a1%2 == 0)
    Console.WriteLine($"Число {a1} - четное");  
else
    Console.WriteLine($"Число {a1} - нечетное");
Console.WriteLine("Расчеты завершены");