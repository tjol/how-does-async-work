using System;
using System.Threading.Tasks;

namespace asyncdemo
{
    class Program
    {
        async static Task Main(string[] args)
        {
            await SillyExample();
        }

        async static Task<int> ReturnNumberAsync(int n)
        {
            Console.WriteLine("In ReturnNumberAsync");
            return n;
        }

        async static Task SillyExample()
        {
            Console.WriteLine("Start of async function");
            var task = ReturnNumberAsync(10);
            Console.WriteLine("Called ReturnNumberAsync(10)");
            int n = await task;
            Console.WriteLine($"Result: {n}");
        }
    }
}
