Console.WriteLine("Hello, World!");
Console.WriteLine("My name is Marina.");
Console.WriteLine();

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0) Console.Write("Feez");
    if (i % 5 == 0) Console.Write("Buzz");
    if (i % 3 != 0 && i % 5 != 0) Console.Write(i);
    Console.WriteLine();
}