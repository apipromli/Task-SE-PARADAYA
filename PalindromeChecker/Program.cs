// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
Console.WriteLine("Masukkan kata apakah kata tersebut termasuk plindrome:");
string input = Console.ReadLine();
string reversed = new string(input.Reverse().ToArray());
if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine($"{input} adalah palindrome.");
}
else
{
    Console.WriteLine($"{input} bukan palindrome.");
}