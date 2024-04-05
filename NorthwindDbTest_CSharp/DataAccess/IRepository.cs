using System.Collections.Generic;

namespace NorthwindDbTest_CSharp.DataAccess
{
    internal interface IRepository<T> where T : class
    {
        /// <summary>
        /// Gets or sets the Northwind API endpoint used by this repository.
        /// </summary>
        string Endpoint { get; }

        /// <summary>
        /// Get all <typeparamref name="T"/> from the API.
        /// </summary>
        /// <typeparam name="T">The model type. Must be a class.</typeparam>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get the <typeparamref name="T"/> from the API with the associated ID.
        /// </summary>
        /// <param name="id">The ID of the record to retrieve.</param>
        /// <returns></returns>
        T GetById(int id);
    }
}
