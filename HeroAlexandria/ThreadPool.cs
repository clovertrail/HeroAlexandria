using System.Diagnostics;
using System.Threading;

namespace HeroAlexandria
{
    public class ThreadPool
    {

        public static double ThreadPoolProcess(int numThreads)
        {
            var start = new Stopwatch();
            using (var e = new AutoResetEvent(false))
            {
                var workerThreads = numThreads;

                start.Start();
                for (var t = 0; t < numThreads; t++)
                {
                    System.Threading.ThreadPool.QueueUserWorkItem(
                        (x) =>
                        {
                            for (var i = Alexandria.LowerBound;
                                i < Alexandria.UpperBound; i++)
                            {
                                if (i % numThreads == t)
                                {
                                    double answer = Alexandria.FindRoot(i);
                                }
                            }

                            if (Interlocked.Decrement(ref workerThreads) == 0)
                            {
                                e.Set();
                            }
                        });
                }

                e.WaitOne();
                start.Stop();
                return start.ElapsedMilliseconds;
            }
        }
    }
}
