/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает
 все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Please, enter your number:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("+++++++++++++");
Console.WriteLine("Got it :)");
Console.WriteLine("Here we go");
Console.WriteLine("+++++++++++++");
if(n % 2 ==0)
{
    while(n > 1)
    {
    Console.WriteLine(n);
    n = n - 2;
    }
}
else
{
    n = n - 1;
    while(n > 1)
    {
    Console.WriteLine(n);
    n = n - 2;
    }
}
