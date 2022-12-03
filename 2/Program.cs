Console.WriteLine("a:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("b:");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{a}, {b}");
if (Math.Pow(b, 2)== a)
{
    Console.WriteLine("a является квадратом b");
}
else 
{
    Console.WriteLine("а не является квадратом b");
}
