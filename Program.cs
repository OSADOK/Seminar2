// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
Console.Clear();
Console.WriteLine("Введите трехзначное чило");
int num = int.Parse(Console.ReadLine());
int n1 = num/10;
int auf = n1%10;

Console.WriteLine($"{auf}");
*/
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Clear();
// Console.WriteLine("Введите чило:");
// int num = int.Parse(Console.ReadLine());
// if (num < 100)
// {
// int n1 = (num % 100) / 10;
// Console.WriteLine("Третьей цифры нет");
// }
// else if (num>=1000 && num<10000)
// {
// int a1 = num / 10;
// int a2 = a1 % 10;    
// Console.WriteLine($"{a2}");
// }
// else if (num>=10000)
// {
// int a1 = num / 100;
// int a2 = a1 % 10;    
// Console.WriteLine($"{a2}");
// }
// else
// {
// int a1 = num % 10;
// int a2 = a1 % 10;    
// Console.WriteLine($"{a2}");
// }


// Console.Clear();
//     Console.WriteLine("Введите чило:");
//     int num = int.Parse(Console.ReadLine());
//     if (num < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//     }
//     else
//     {
//         Console.WriteLine(Convert.ToString(num)[2]);
//     }

// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите чило от 1 до 7:");
int a = int.Parse(Console.ReadLine());
if (a == 7 || a == 6)
{
Console.Write($"Под цифрой{a}да, выходной");
}
else
{
Console.Write($"Под цифрой {a}нет, не выходной");
}