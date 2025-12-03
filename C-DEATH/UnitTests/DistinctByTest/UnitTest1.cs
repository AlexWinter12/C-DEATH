namespace MethodDistinctBy;

public class MethodDistinctByTest
{
    [Fact]
    public void GetUniqueValues_ReturnList()
    {
        // arrange 
        var id = Guid.NewGuid();
        var filter = new DistinctBy();
        var users = new List<User>
        
        {
            new User { Id = id, Age = 1, Name = "User1" },
            new User { Id = id, Age = 2, Name = "User2" },
            new User { Id = Guid.NewGuid(), Age = 2, Name = "User3" },
        };
            
         // act 
         var result = filter.DistinctByIdUsers(users).ToList();

         // assert
         Assert.Equal(2, result.Count);
         Assert.Single(result.Where(x => x.Id == id));
    }

    [Fact]
    public void GetEmptyCollection_ReturnEmptiness()
    {
        // arrange 
        var filter = new DistinctBy();
        var users = new List<User>();
        
        // act 
        var result = filter.DistinctByIdUsers(users).ToList();
        
        // assert 
        Assert.Empty(result);
    }

    [Fact]
    public void  GetUniqueValuesFromMultipleGroups_ReturnList()
    {
        // assert 
        var id1 = Guid.NewGuid();
        var id2 = Guid.NewGuid();
        var filter = new DistinctBy();
        var users = new List<User>()
        {
            new User { Id = id1, Age = 2, Name = "User1" },
            new User { Id = id2, Age = 2, Name = "User2" },
            new User { Id = id2, Age = 4, Name = "User3" },
            new User { Id = id1, Age = 5, Name = "User4" },
        };
        
        // act 
        var result = filter.DistinctByIdUsers(users).ToList();
        
        // assert
        Assert.Equal(2, result.Count);
        Assert.Single(result.Where(x => x.Id == id1));
        Assert.Single(result.Where(x => x.Id == id2));

    }
}