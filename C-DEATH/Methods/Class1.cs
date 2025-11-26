using System.Collections.Generic;
using System.Linq;
namespace OddNumbersFilter

{
    public class OddNumbers
    {
        public IEnumerable<int> GetOdd(ICollection<int>? nums)
        {
            if (nums == null)
            {
                return Enumerable.Empty<int>();
            }
            return nums.Where(n => n % 2 != 0);
        }
    }
}

namespace PositiveNumbersFilter
{
    public class PositiveNumbers
    {
        public IEnumerable<int> GetPositiveNumbers(IEnumerable<int>? numbers)
        {
            if (numbers == null)
            {
                return Enumerable.Empty<int>();
            }
            return numbers.Where(n => n > 0);
        }
    }
}

namespace OrderOfElementsFilter
{
    public class OrderOfElements
    {

        public ICollection<int> ReverseUserIds(ICollection<int>? userIds)
        {
            if (userIds == null)
            {
                return Array.Empty<int>();
            }
            var list = userIds.ToList();
            list.Reverse();
            return list;
        }

    }
}
