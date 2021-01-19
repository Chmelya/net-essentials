using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaskLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskLibarayTestAsync().GetAwaiter().GetResult();
        }

        static async Task TaskLibarayTestAsync()
        {
            List<Task> tasks;
            var tokenSource = new CancellationTokenSource(2000);
            var token = tokenSource.Token;

            await TaskCreater.CreateTask();

            await TaskCreater.CreateTask(token);

            tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(TaskCreater.CreateTask(token));
            }
            await Task.WhenAll(tasks.ToArray());


            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
            tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(TaskCreater.CreateTask(token));
            }
            await Task.WhenAny(tasks.ToArray());
            tokenSource.Cancel();
        }
    }
}
