// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int sum = 0;
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
    {
        sum += i;
        Console.WriteLine($"{sum}");
    }
}