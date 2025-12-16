// // See https://aka.ms/new-console-template for more information
// // Console.WriteLine("Hello, World!");

// // int nilai = 100;

// // int score = 80;
// // if (score >= 90)
// // {
// //     Console.WriteLine("A");
// // }
// // else if (score >= 80)
// // {
// //     Console.WriteLine("B");
// // }
// // else
// // {
// //     Console.WriteLine("C");
// // }

// switch (day)
// {
//     case "Mon": Console.WriteLine("Start!"); break;
//     case "Fri": Console.WriteLine("Weekend Soon!!"); break;
//     default: Console.WriteLine("Midweek!"); break;
// }

// // for (int i = 0; i < 5; i++)
// //     Console.WriteLine(i);

// // int n = 0;
// // while (n < 3)
// // {
// //     Console.WriteLine(Repeat);
// //     n++;
// // }

// // string[] names = { "Ana", "Ben", "Cleo" };
// // foreach (string name in names)
// // {
// //     Console.WriteLine(name);
// // }

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
        Console.WriteLine("FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine("Fizz");
    else if (i % 5 == 0)
        Console.WriteLine("Buzz");
    else
        Console.WriteLine(i);
}