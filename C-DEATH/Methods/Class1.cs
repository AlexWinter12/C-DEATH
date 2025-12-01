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

            var list = userIds;
            list.Reverse();
            return list;
        }

    }
}

namespace MethodForCheckingConditions
{
    public sealed record User
    {
        public required Guid Id { get; init; }
        public required int Age { get; init; }
        public string? Name { get; init; }
    }

    public class UserCheck
    {
        public bool AllAdultUsers(ICollection<User>? users)
        {
            if (users == null)
            {
                return false;
            }

            return users.All(u => u.Age >= 18);
        }

        public bool AnyAdultUser(ICollection<User>? users)
        {

            if (users == null)
            {
                return false;
            }

            return users.Any(u => u.Age >= 18);
        }

        public bool ContainsAdultUser(ICollection<User>? users)
        {
            if (users == null)
            {
                return false;
            }

            var MyUser = new User
            {
                Id = Guid.NewGuid(),
                Age = 18,
                Name = null
            };
            var ages = users.Select(u => u.Age);
            return ages.Contains(MyUser.Age);
        }

    }
}

namespace MethodCastIntInLong
{
    class CastIntLong
    {
        public ICollection<long> CastIntToLong(ICollection<int> list)
        {
            return list.Select(i => (long)(i)).ToList();
            
        }
    }
}

namespace MethodGroupby
{
    public sealed record User
    {
        public required Guid Id { get; init; }
        public required int Age { get; init; }
        public string? Name { get; init; }
    }

    public class GroupBy
    {
        public Dictionary<int, List<User>> GroupUsersByAge(ICollection<User> users)
        {
            return users.GroupBy(u=>u.Age)
                .ToDictionary(g=>g.Key, 
                    g=>g.ToList());
            
        }
    }
}