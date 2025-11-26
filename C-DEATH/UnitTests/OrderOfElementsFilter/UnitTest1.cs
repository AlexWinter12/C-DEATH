namespace OrderOfElementsFilter;

public class OrderOfElementsFilterTest
{
    [Fact]
    public void GetExpandedValues_ReturnList()
    {
        // Arrange
        var userIds =  new[] { 1, 2, 3 };
        var filter = new OrderOfElements();
        var expected = new[] { 3, 2, 1};
        
        // Act 
        var result = filter.ReverseUserIds(userIds).ToList();
        
        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetExpandedValuesWithNegative_ReturnList()
    {
        // Arrange 
        var userIds = new[] { -2,4,-5,-6 };
        var filter = new OrderOfElements();
        var expected = new[] { -6,-5,4, -2 };
        
        // Act 
        var result = filter.ReverseUserIds(userIds).ToList();
        
        // Assert
        Assert.Equal(expected, result);

    }

    [Fact]
    public void GetNull_ReturnsEmptiness()
    {
        // Arrange 
        var filter = new OrderOfElements();
        
        // Act
        var result = filter.ReverseUserIds(null).ToList();
        
        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void GetEmptiness_ReturnTheEmptiness()
    {
        // Arrange 
        var userIds = Array.Empty<int>();
        var filter = new OrderOfElements();
        
        // Act
        var result = filter.ReverseUserIds(userIds).ToList();
        
        // Assert 
        Assert.Empty(result);
        
    }

    [Fact]
    public void GetExpandedValuesWithRepetition_ReturnList()
    {
        // Arrange 
        var userIds = new[] { 1, 2, 1, 1, 3, 1, 3 };
        var filter = new OrderOfElements();
        var expected = new[] { 3, 1, 3, 1, 1, 2, 1 };

        // Act 
        var result = filter.ReverseUserIds(userIds).ToList();

        // Assert
        Assert.Equal(expected, result);
    }

}