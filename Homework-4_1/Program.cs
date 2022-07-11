Console.WriteLine("Enter number:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("+++++++++++++++++");
Console.WriteLine("Got it:)");
Console.WriteLine("Here we go!");
Console.WriteLine("+++++++++++++++++");
int a = 2;
if(n % 2 == 0)
{
    while(a < n)
    {
        Console.WriteLine(a);
        a = a + 2;
    }
    Console.WriteLine(n);
}
else
{
    while(a < n)
    {
        Console.WriteLine(a);
        a = a + 2;
    }
}
