using System;
using System.Threading.Tasks;

class AsyncDemoNoAsync
{
    static void Main(string[] args)
    {
        var t = SillyExample();
        Console.WriteLine("Waiting");
        t.Wait();
        Console.WriteLine("Done");
    }

    static Task<int> ReturnNumberAsync(int n)
    {
        var t = new Task<int>(
            delegate()
            {
                Console.WriteLine("In ReturnNumberAsync");
                return n;
            });
        t.RunSynchronously();
        return t;
    }

    static Task SillyExample()
    {
        Console.WriteLine("Start of async function");
        var task = ReturnNumberAsync(10);
        Console.WriteLine("Called ReturnNumberAsync(10)");
        return task.ContinueWith(
            delegate(Task<int> t)
            {
                int n = t.Result;
                Console.WriteLine($"Result: {n}");
            }
        );
    }
}
