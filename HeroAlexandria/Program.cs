using System;

namespace HeroAlexandria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Thread Pool: {ThreadPool.ThreadPoolProcess(100)} ms");
            //Console.WriteLine("Single thread: " + SingleThread.SingleThreadProcess());
            
        }
    }
}
