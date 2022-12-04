using System.Diagnostics;

namespace Module_13._6_FinalTask_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = Stopwatch.StartNew();
            var strings = new List<string>();
            string text = File.ReadAllText("D:\\Domeny\\Downloads\\Text1.txt");
            strings.Add(text);
            Console.WriteLine($"List Time Elapsed: {stopWatch.Elapsed.TotalMilliseconds} ms");//8ms

            stopWatch = Stopwatch.StartNew();
            LinkedList<string> LinkedList = new LinkedList<string>();
            text = File.ReadAllText("D:\\Domeny\\Downloads\\Text1.txt");
            LinkedList.AddFirst(text);
            Console.WriteLine($"LinkedList Time Elapsed: {stopWatch.Elapsed.TotalMilliseconds} ms");//4ms, Two times faster.
        }
    }
}