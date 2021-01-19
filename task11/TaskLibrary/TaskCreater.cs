using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class TaskCreater
    {
        static int iterationsMax = new Random().Next(5, 30);
        public static Task CreateTask(CancellationToken ct = default)
        {
            return Task.Run(() => {
                
                for (int i = 1; i <= iterationsMax; i++)
                {
                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }

                    Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}. IterationsMax: {iterationsMax}. IterationCurrent: {i}");

                    Task.Delay(new Random().Next(200, 300));
                }
            },
            ct);
        }
    }
}
