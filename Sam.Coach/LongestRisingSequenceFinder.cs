using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sam.Coach
{
    public class LongestRisingSequenceFinder : ILongestRisingSequenceFinder
    {
        // this method is O(n^2) approach (in the worst case).
        /*
         * The idea of this algorithm is to form a maximum subsequence for each element.
         * If this is the longest length, it will be the final result.
         */
        public Task<IEnumerable<int>> Find(IEnumerable<int> numbers) => Task.Run(() =>
        {
            IEnumerable<int> result = null;

            // TODO: return the longest raising sequence in the collection provided, i.e.
            // when numbers = [4, 6, -3, 3, 7, 9] then expected result is [-3, 3, 7, 9]
            // when numbers = [9, 6, 4, 5, 2, 0] then expected result is [4, 5]

            var maxFlag = -1;
            for (int i = 0; i < numbers.Count(); i++)
            {
                List<int> partialSequence = new List<int>();
                var finish = false;
                var j = i;
                while (!finish)
                {
                    if (j + 1 < numbers.Count())
                    {
                        if (numbers.ElementAt(j) >= numbers.ElementAt(j + 1)) finish = true; // no more sequence
                    }
                    else
                    {
                        finish = true;
                    }
                    partialSequence.Add(numbers.ElementAt(j));
                    j++;
                }
                if (partialSequence.Count > maxFlag)
                {
                    maxFlag = partialSequence.Count;
                    result = partialSequence;
                }
            }
            return result;
        });
    }
}
