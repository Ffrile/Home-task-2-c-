// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100)
{
    System.Console.WriteLine("нет третьего числа");
}
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }
    System.Console.WriteLine(num % 10);
}




// int count = 1;
// int num2 = num;
// while ((num2 / 10) > 0)
// {
//     count++;
//     num2 = num2 / 10;
// }
// if (count > 2)
// {
//     num2 = (num / Convert.ToInt32(Math.Pow(10, (count - 3))) % 10);
//     System.Console.WriteLine(num2);
// }
// else
// {
//     System.Console.WriteLine("нет третьего числа");
// }
