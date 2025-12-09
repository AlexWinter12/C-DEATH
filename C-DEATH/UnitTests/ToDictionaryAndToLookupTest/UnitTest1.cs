namespace ToDictionaryAndToLookup;

public class ToDictionaryAndToLookupTest
{
        [Fact]
        public void GetGroupUniqueByKeys_ReturnDictionary()
        {
            // arrange
            var users = new List<User>
            {
                new User { Id = Guid.NewGuid(), Age = 21, Name = "User1" },
                new User { Id = Guid.NewGuid(), Age = 52, Name = "User2" },
                new User { Id = Guid.NewGuid(), Age = 52, Name = "User3" }, 
            };
            var service = new ToDictionary();

            // act
            var result = service.GroupByAgeUsingDictionary(users);

            // assert
            Assert.Equal(2, result.Count);
            Assert.Contains(21, result.Keys);
            Assert.Contains(52, result.Keys);
        }
        
        [Fact]
        public void GetEmptyCollectionUsingDictionary_ReturnEmptiness()
        {
            // arrange
            var users = new List<User>();
            var service = new ToDictionary();

            // act
            var result = service.GroupByAgeUsingDictionary(users);

            // assert
            Assert.Empty(result);
        }
        
        [Fact]
        public void GetGroupByKeys_ReturnLookup()
        {
            // arrange
            var users = new List<User>
            {
                new User { Id = Guid.NewGuid(), Age = 52, Name = "User1" },
                new User { Id = Guid.NewGuid(), Age = 21, Name = "User2" },
                new User { Id = Guid.NewGuid(), Age = 52, Name = "User3" }
            };

            var service = new ToLookup();

            // act
            var result = service.GroupByAgeUsingLookup(users);

            // assert
            Assert.Equal(2, result.Count());
            Assert.Equal(2, result[52].Count());
            Assert.Single(result[21]);
            Assert.Contains(result[52], u => u.Name == "User1");
            Assert.Contains(result[52], u => u.Name == "User3");
        }
        [Fact]
        public void GetEmptyCollectionUsingLookup_ReturnEmptiness()
        {
            // arrange
            var users = new List<User>();
            var service = new ToLookup();

            // act
            var result = service.GroupByAgeUsingLookup(users);

            // assert
            Assert.Empty(result);
        }

}