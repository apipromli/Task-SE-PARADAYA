using TaskManagerCLI;

public class Program
{
    public static void Main(string[] args)
    {

        List<TaskItem> tasks = new();
        int id = 1;
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Add | 2. List | 3. Complete | 4. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Title:");
                    tasks.Add(new TaskItem
                    {
                        Id = id++,
                        Title = Console.ReadLine()
                    });
                    break;
                case "2":
                    foreach (var t in tasks)
                        Console.WriteLine($"{t.Id}. {t.Title} - {(t.IsCompleted ? "Done" : "Pending")} ");
                    break;
                case "3":
                    Console.Write("Enter ID: ");
                    int markId = int.Parse(Console.ReadLine());
                    tasks.Find(t => t.Id == markId)?.MarkCompleted();
                    break;
                case "4":
                    running = false; break;
            }
        }
    }
}
