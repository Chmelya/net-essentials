using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using TaskLibrary;

namespace ConsoleApp
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            CancellationTokenSource tokenSource;
            CancellationToken token;

            try
            {
                await TaskCreator.CreateTask();
            }
            catch (System.Threading.Tasks.TaskCanceledException)
            {

            }

            try
            {
                tokenSource = new CancellationTokenSource(2000);
                token = tokenSource.Token;
                await TaskCreator.CreateTask(token);
            }
            catch (System.Threading.Tasks.TaskCanceledException)
            {

            }

            try
            {
                tokenSource = new CancellationTokenSource(2000);
                token = tokenSource.Token;
                for (int i = 0; i < 10; i++)
                {
                    tasks.Add(TaskCreator.CreateTask(token));
                }
                await Task.WhenAll(tasks);
            }
            catch (AggregateException ae)
            {

            }
            finally
            {
                tasks.Clear();
            }

            try
            {
                tokenSource = new CancellationTokenSource();
                token = tokenSource.Token;
                for (int i = 0; i < 10; i++)
                {
                    tasks.Add(TaskCreator.CreateTask(token));
                }
                await Task.WhenAny(tasks);
                tokenSource.Cancel();
            }
            catch (AggregateException ae)
            {

            }
        }
    }
}
