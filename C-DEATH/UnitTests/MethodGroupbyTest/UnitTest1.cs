namespace MethodGroupby;

public class MethodGroupbyTest
{
    [Fact]
    public void GetGroupedValues_Returnlist()
    {
        // Arrange 
        var filter = new GroupBy();
        var users = new List<User>
        {
            new User { Id = Guid.NewGuid(), Age = 52, Name = "Artemiy" },
            new User { Id = Guid.NewGuid(), Age = 67, Name = "Samohvalov" },
            new User { Id = Guid.NewGuid(), Age = 52, Name = "Nikita" }
        };
        
        // Act 
        var result = filter.GroupUsersByAge(users);
        
        // Assert 
        Assert.Equal(2, result.Count);
        Assert.Equal(2, result[52].Count);
        Assert.Equal(1,result[67].Count);

    }

    [Fact]
    public void GetEmptyCollection_ReturnEmptiness()
    {
        // Arrange
        var filter = new GroupBy();
        var users = new List<User>();
        
        // Act 
        var result = filter.GroupUsersByAge(users);
        
        // Assert 
        Assert.Empty(result);
    }

    [Fact]
    public void GetGroupedValuesWithNegativeNumber_ReturnList()
    {
        // Arrange
        var filter = new GroupBy();
        var users = new List<User>
        {
            new User { Id = Guid.NewGuid(), Age = 52, Name = "Artemiy" },
            new User { Id = Guid.NewGuid(), Age = -100, Name = "Samohvalov" },
            new User { Id = Guid.NewGuid(), Age = 52, Name = "Nikita" }
        };
        
        // Act 
        var result = filter.GroupUsersByAge(users);
        
        // Assert 
        Assert.Equal(2, result.Count);
        Assert.Equal(2, result[52].Count);
        Assert.Equal(1, result[-100].Count);
    }
}