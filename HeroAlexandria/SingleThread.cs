using System.Diagnostics;

namespace HeroAlexandria
{
    public class SingleThread
    {
        public static double SingleThreadProcess()
        {
            Stopwatch start = new Stopwatch();
            start.Start();
            for (var i = Alexandria.LowerBound; i <= Alexandria.UpperBound; i++)
            {
                double answer = Alexandria.FindRoot(i);
            }
            start.Stop();
            return start.ElapsedMilliseconds;
        }
    }
}
