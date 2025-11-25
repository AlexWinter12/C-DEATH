using PositiveNumbersFilter;

public class PositiveNumbersFilterTest
{
    [Fact]
    public void GetPositive_ReturnsPositive()
    {
        // Arrange
        var numbers = new[] { 1, -2, 3, -4, 5 };
        var filter = new PositiveNumbers();
        var expected = new[] { 1, 3, 5 };

        // Act
        var result = filter.GetPositiveNumbers(numbers).ToList();

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void GetNegative_ReturnsEmptiness()
    {

        // Arrange
        var numbers = new[] { -3, -4, -5, -7, -8 };
        var filter = new PositiveNumbers();

        // Act
        var result = filter.GetPositiveNumbers(numbers).ToList();

        // Assert
        Assert.Empty(result);

    }

    [Fact]
    public void GetNull_ReturnsEmptiness()
    {
        
        // Arrange 
        var filter = new PositiveNumbers();
        
        // Act 
        var result = filter.GetPositiveNumbers(null);
        
        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void GetEmptiness_ReturnTheEmptiness()
    {
        // Arange
        var numbers = Array.Empty<int>();
        var filter = new PositiveNumbers();
        
        // Act 
        var result = filter.GetPositiveNumbers(numbers).ToList();
        
        // Assert
        Assert.Empty(result);

    }
}