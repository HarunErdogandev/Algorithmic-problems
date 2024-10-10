// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



Console.WriteLine(new Bagel().Value);















sealed class Bagel
{
    public int Value { get; private set; } = 3;
}