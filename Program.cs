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

Console.Clear();
Console.WriteLine("Введите чило:");
int num = int.Parse(Console.ReadLine());
if (num < 100)
{
    int n1 = (num % 100) / 10;
    Console.WriteLine("Третьей цифры нет");
}
else {
    for(num>=1000);
    int z = (num % 100) / 10;
    Console.WriteLine($"{z}");
    }
    

// }
//         else {

//         // int n3 = num%10;
//         // Console.WriteLine($"{n3}");
// }

