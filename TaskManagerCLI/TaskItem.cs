// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
namespace TaskManagerCLI;
public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsCompleted { get; set; }

    public void MarkCompleted() =>
        IsCompleted = true;
}
