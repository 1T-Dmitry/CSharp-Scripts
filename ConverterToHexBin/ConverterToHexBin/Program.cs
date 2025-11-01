Console.WriteLine("Enter text to convert it to binary and hexadecimal representation:");
string text = Console.ReadLine() ?? "";
Console.WriteLine();

Console.WriteLine("Binary representation:");
foreach (char c in text)
{
    Console.Write(Convert.ToString(c, 2));
}
Console.Write("\n\n");

Console.WriteLine("Hexadecimal representation:");
foreach (char c in text)
{
    Console.Write(Convert.ToString(c, 16));
}
Console.WriteLine();
