using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskLibrary
{
    public class TaskCreator
    {
        private static Random rand = new Random();
        public static Task CreateTask(CancellationToken ct = default)
        {
            int iterationsMax = rand.Next(5, 30);
            return Task.Run(async () => {
                
                for (int i = 1; i <= iterationsMax; i++)
                {
                    if (ct.IsCancellationRequested)
                    {
                        break;
                    }

                    await Task.Delay(rand.Next(200, 300));
                    
                    Console.WriteLine($"Thread:{Thread.CurrentThread.ManagedThreadId}. IterationsMax: {iterationsMax}. IterationCurrent: {i}");
                }
            });
        }
    }
}
