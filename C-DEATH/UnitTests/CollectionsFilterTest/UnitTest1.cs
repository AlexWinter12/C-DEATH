using OddNumbersFilter;

public class OddNumbersTest
{
    //Обычный набор
    [Fact]
    public void 
        CheckRegularSet()
    {
        // Arrange
        var nums = new[] { 1, 2, 3, 4, 5 };
        var filter = new OddNumbers();
        var expected = new[] { 1, 3, 5 };
        
        // Act
        var result = filter.GetOdd(nums).ToList();
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    //Набор с отрицательными 
    [Fact]
    public void CheckRegular_set_Negative()
    
    {   // Arrange
        var nums = new[] { 1, 2, -4, -5, 6 };
        var filter = new OddNumbers();
        var expected = new[] { 1, -5 };
        
        //Act
        var result = filter.GetOdd(nums).ToList();
        
        // Assert
        Assert.Equal(expected, result);
    }
    
    //Только отрицательные
    [Fact]
    public void CheckNegativeSet()
    {
        //Arrange
        var nums = new[] {-3,-7,-9};
        var filter = new OddNumbers();
        var expected = new[] { -3, -7, -9 };
        
        //Act 
        var result = filter.GetOdd(nums).ToList();
        
        // Assert 
        Assert.Equal(expected, result);
    }

    //Null
    [Fact]
    public void CheckNull()
    {
        //Arrange
        var filter = new OddNumbers();
        
        // Act
        var result = filter.GetOdd(null);
        
        // Assert
        Assert.Empty(result);

    }

}