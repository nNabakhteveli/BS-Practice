﻿using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    /// <summary>
    /// Considers the differences between eager or lazy query execution.
    /// </summary>
    public static class QueryExecution
    {
        /// <summary>
        /// Finds all elements of an array more than 5. Implement as deferred query execution
        /// </summary>
        /// <returns>All elements of an array more than 5.</returns>
        public static IEnumerable<int> DeferredExecution()
        {
            var numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //TODO: Create a LINQ query that finds all array elements with a value greater than 5, and assign it to the variable numberMore5.
            IEnumerable<int> numberMore5 = (
                    from num in numbers
                    where num > 5
                    select num
                );

            numbers.Add(10);

            var result = new List<int>();

            foreach (var item in numberMore5)
            {
                result.Add(item);
            }

            return result;
        }

        /// <summary>
        /// Finds all elements of an array more than 5. Implement as immediate query execution.
        /// </summary>
        /// <returns>All elements of an array more than 5.</returns>
        public static IEnumerable<int> ImmediateExecution()
        {
            var numbers = new List<int> { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //TODO: Create a LINQ query that finds all array elements with a value greater than 5, and assign it to the variable numberMore5.
            IEnumerable<int> numberMore5 = (
                from num in numbers
                where num > 5
                select num
            ).ToList();

            numbers.Add(10);

            var result = new List<int>();

            foreach (var item in numberMore5)
            {
                result.Add(item);
            }

            return result;
        }
    }
}