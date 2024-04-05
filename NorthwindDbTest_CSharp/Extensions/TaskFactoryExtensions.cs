using System;
using System.Threading.Tasks;

namespace NorthwindDbTest_CSharp.Extensions
{
    /// <summary>
    /// A set of extension methods for working with the <see cref="TaskFactory"/>.
    /// </summary>
    public static class TaskFactoryExtensions
    {
        /// <summary>
        /// Creates, starts, and returns the results of a <see cref="Task{TResult}"/>.
        /// </summary>
        /// <typeparam name="TResult">The return type.</typeparam>
        /// <param name="factory">The <see cref="TaskFactory"/> instance to use.</param>
        /// <param name="function">A function delegate to run in the task.</param>
        /// <returns></returns>
        public static TResult RunAsyncWithResult<TResult>(this TaskFactory factory, Func<Task<TResult>> function)
        {
            return factory
                .StartNew(function)
                .Unwrap()
                .GetAwaiter()
                .GetResult();
        }
    }
}