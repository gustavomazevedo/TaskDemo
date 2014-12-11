using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskDemo
{
    public static class Extensions
    {
        //http://www.codeproject.com/Articles/691202/Using-the-Task-Parallel-Library-TPL-in-WPF
        public static Task MainUIContinueWith<T>(this Task<T> task, Action<Task<T>> function)
        {
            return task.ContinueWith(function, 
                                     CancellationToken.None, 
                                     TaskContinuationOptions.None, 
                                     TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
