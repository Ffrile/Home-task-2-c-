// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

System.Console.WriteLine("Введите число");;
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
{
    System.Console.WriteLine("Выходной");;
}
else
{
System.Console.WriteLine("Будний");
}