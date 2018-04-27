using Xunit;

namespace ForestControl.test {
 
  /// <summary>
  /// The grid test class for unit testing.
  /// </summary>
  public class GridTest {

    [Fact]
    public void APositionOutsideGridIsInvalid() {
      int maxRangeX = 4;
      int maxRangeY = 5;
      int positionX = 10;
      int positionY = 2;
      
      Grid grid = new Grid(maxRangeX, maxRangeY);
      
      Assert.False(grid.IsValidPosition(positionX, positionY));
    }
    
    [Fact]
    public void APositionInsideGridIsValid() {
      int maxRangeX = 4;
      int maxRangeY = 5;
      int positionX = 2;
      int positionY = 2;
      
      Grid grid = new Grid(maxRangeX, maxRangeY);
      
      Assert.True(grid.IsValidPosition(positionX, positionY));
    }
  }
}