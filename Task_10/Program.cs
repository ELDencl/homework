// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
int Num = new Random().Next(100, 1000);
Console.WriteLine(Num);

int SecondNum = (Num / 10) % 10;
Console.WriteLine($"Второй цифрой числа {Num} является {SecondNum}");