using System;

namespace ForestControl {
 
  /// <summary>
  /// The grid class representation.
  /// </summary>
  public class Grid {

    private static readonly int MIN = 0;
    
    private int mMaxRangeX;
    private int mMaxRangeY;

    /// <summary>
    /// Initializes a Grid class instance.
    /// </summary>
    /// <param name="maxRangeX">An integer which represents the max range on the X axis to build a rectangle area.</param>
    /// <param name="maxRangeY">An integer which represents the max range on the Y axis to build a rectangle area.</param>
    public Grid(int maxRangeX, int maxRangeY) {
      mMaxRangeX = maxRangeX;
      mMaxRangeY = maxRangeY;
    }

    /// <summary>
    /// Checks if a position given is valid or not inside the grid representation.
    /// </summary>
    /// <param name="x">An integer which represent a position on the X axis.</param>
    /// <param name="y">An integer which represent a position on the Y axis.</param>
    /// <returns><code>True</code> if the position is valid, otherwhise <code>False</code>.</returns>
    public bool IsValidPosition(int x, int y) {
      return (x >= MIN && x <= mMaxRangeX && y >= MIN && y <= mMaxRangeY);
    }
  }
}