Console.Write("""
    This program calculates the scalar and vector product of vectors.
    1. The scalar product.
    2. Vector product.
    : 
    """);
int choice = Convert.ToInt32(Console.ReadLine());

Console.Write("vectorA: ");
int vectorA = Convert.ToInt32(Console.ReadLine());

Console.Write("vectorB: ");
int vectorB = Convert.ToInt32(Console.ReadLine());

Console.Write("corner: ");
int corner = Convert.ToInt32(Console.ReadLine());
double cornerRadians = corner * Math.PI / 180;

if (choice == 1)
{
    double result = Math.Abs(vectorA) * Math.Abs(vectorB) * Math.Cos(cornerRadians);
    Console.WriteLine($"result: {result}");
}
else if (choice == 2)
{
    double result = Math.Abs(vectorA) * Math.Abs(vectorB) * Math.Sin(cornerRadians);
    Console.WriteLine($"result: {result}");
}
else
{
    Console.WriteLine("There is no such choice!");
}
