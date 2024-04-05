using System.Collections.Generic;

namespace NorthwindDbTest_CSharp.Services
{
    /// <summary>
    /// A simple interface for converting source models into view models.
    /// </summary>
    /// <typeparam name="TResult">The view model type that is returned.</typeparam>
    /// <typeparam name="TSource">The model used as a source to construct the result.</typeparam>
    internal interface IViewModelService<TResult, TSource> 
        where TResult : class
        where TSource : class
    {
        TResult CreateViewModel(TSource source);
        IEnumerable<TResult> CreateViewModel(IEnumerable<TSource> source);
    }
}
