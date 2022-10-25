// Console.WriteLine("enter first number: ");
// int x = int.Parse(Console.ReadLine());

// Console.WriteLine("enter second number: ");
// int y = int.Parse(Console.ReadLine());

// Console.WriteLine($"Result is {Math.Pow(x,y)}");

Console.WriteLine("enter x: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("enter y: ");
int y = int.Parse(Console.ReadLine());
int power = x;

for (int i = 1; i < y; i++)
{
    power = power * x;
}
Console.WriteLine($"Result = {power}");