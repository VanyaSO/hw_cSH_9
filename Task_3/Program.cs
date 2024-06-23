namespace Task_3;

class Program
{
    static async Task Main(string[] args)
    {
        var queue = new PriorityQueue<string, int>();
        queue.Enqueue("Fill", 1);
        queue.Enqueue("Kirill", 2);
        queue.Enqueue("Max", 3);
        queue.Enqueue("Petr", 4);

        Console.WriteLine("Прием пациентов");
        while (queue.Count > 0)
        {
            var item = queue.Dequeue();
            Console.WriteLine($"Врач принимает: {item}");
            await Task.Delay(5000);
        }
        
        
    }
}