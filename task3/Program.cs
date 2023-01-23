//  Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

System.Console.WriteLine("Введите трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

num = (num / 10) % 10;

System.Console.WriteLine(num);