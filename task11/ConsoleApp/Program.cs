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
            List<Task> tasks;
            var tokenSource = new CancellationTokenSource(2000);
            var token = tokenSource.Token;

            //TaskCreater.CreateTask();

            //TaskCreater.CreateTask(token);

            //tasks = new List<Task>();
            //for(int i = 0; i < 10; i++)
            //{
            //    tasks.Add(TaskCreater.CreateTask(token));
            //}
            //Task.WaitAll(tasks.ToArray());


            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
            tasks = new List<Task>();
            for (int i = 0; i < 10; i++)
            {
                tasks.Add(TaskCreater.CreateTask(token));
            }
            Task.WaitAny(tasks.ToArray());
            tokenSource.Cancel();

            Console.ReadKey();
        }
    }
}
