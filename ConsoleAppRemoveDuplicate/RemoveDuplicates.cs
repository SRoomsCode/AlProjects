using System;
using System.Collections.Generic;
using System.Linq;

namespace Removeduplicatesnamespace
{
    public class ListProcessor
    {
        public void ProcessList()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 1, 2, 3, 4, 5 };
            
            Console.WriteLine("Original List: " + string.Join(", ", numbers));

            List<int> duplicates = numbers.GroupBy(x => x)
                                          .Where(g => g.Count() > 1)
                                          .Select(y => y.Key)
                                          .ToList();

            numbers = numbers.Distinct().ToList();

            Console.WriteLine("New List: " + string.Join(", ", numbers));
            Console.WriteLine("Duplicates: " + string.Join(", ", duplicates));
        }
    }
}