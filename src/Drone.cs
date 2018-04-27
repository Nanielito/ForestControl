using System;
using System.Collections.Generic;

namespace ForestControl {

  /// <summary>
  /// The drone class representation.
  /// </summary>
  public class Drone {
    
    private int mPositionX;
    private int mPositionY;
    private char mDirection;

    /// <summary>
    /// Initializes a default Drone class instance.
    /// </summary>
    public Drone() {
      
    }
    
    /// <summary>
    /// Initializes a Drone class instance.
    /// </summary>
    /// <param name="positionX">An integer which represents a X axis position.</param>
    /// <param name="positionY">An integer which represents a Y axis position.</param>
    /// <param name="direction">A character which represents a direction.
    ///   <remarks>It must be N for North, S for South, E for East, or W for West</remarks>
    /// </param>
    public Drone(int positionX, int positionY, char direction) {
      mPositionX = positionX;
      mPositionY = positionY;
      mDirection = direction;
    }

    /// <summary>
    /// Sets the <code>mPositionX</code> property value.
    /// </summary>
    /// <param name="positionX">An integer value which represents a X axis position.</param>
    public void SetPositionX(int positionX) {
      mPositionX = positionX;
    }

    /// <summary>
    /// Gets the <code>mPositionX</code> property value.
    /// </summary>
    /// <returns>The <code>mPositionX</code> property value.</returns>
    public int GetPositionX() {
      return mPositionX;
    }
    
    /// <summary>
    /// Sets the <code>mPositionY</code> property value.
    /// </summary>
    /// <param name="positionY">An integer value which represents a Y axis position.</param>
    public void SetPositionY(int positionY) {
      mPositionY = positionY;
    }

    /// <summary>
    /// Gets the <code>mPositionY</code> property value.
    /// </summary>
    /// <returns>The <code>mPositionY</code> property value.</returns>
    public int GetPositionY() {
      return mPositionY;
    }

    /// <summary>
    /// Sets the <code>mDirection</code> property value.
    /// </summary>
    /// <param name="direction">An integer value which represents a direction.
    ///   <remarks>It must be N for North, S for South, E for East, or W for West</remarks>
    /// </param>
    public void SetDirection(char direction) {
      mDirection = direction;
    }

    /// <summary>
    /// Gets the <code>mDirection</code> property value.
    /// </summary>
    /// <returns>The <code>mDirection</code> property value.</returns>
    public char GetDirection() {
      return mDirection;
    }

    /// <summary>
    /// Updates the drone position according to its direction.
    /// </summary>
    /// <param name="map">The grid instance which represents a rectangle area.</param>
    public void MoveForward(Grid map) {
      if (mDirection == 'N' && map.IsValidPosition(mPositionX, mPositionY + 1)) {
        mPositionY += 1;
      }
      else if (mDirection == 'E' && map.IsValidPosition(mPositionX + 1, mPositionY)) {
        mPositionX += 1;
      }
      else if (mDirection == 'S' && map.IsValidPosition(mPositionX, mPositionY - 1)) {
        mPositionY -= 1;
      }
      else if (mDirection == 'W' && map.IsValidPosition(mPositionX - 1, mPositionY)) {
        mPositionX -= 1;
      }
    }

    /// <summary>
    /// Updates the drone direction according to its current direction. It rotates the drone 90 grades to left.
    /// </summary>
    public void TurnLeft() {
      switch (mDirection) {
        case 'N':
          mDirection = 'W';
          break;
        case 'E':
          mDirection = 'N';
          break;
        case 'S':
          mDirection = 'E';
          break;
        default:
          mDirection = 'S';
          break;
      }
    }
    
    /// <summary>
    /// Updates the drone direction according to its current direction. It rotates the drone 90 grades to right.
    /// </summary>
    public void TurnRight() {
      switch (mDirection) {
        case 'N':
          mDirection = 'E';
          break;
        case 'E':
          mDirection = 'S';
          break;
        case 'S':
          mDirection = 'W';
          break;
        default:
          mDirection = 'N';
          break;
      }
    }

    /// <summary>
    /// Executes a move.
    /// </summary>
    /// <param name="map">The grid instance which represents a rectangle area.</param>
    /// <param name="move">A char which represent the move to be done.
    ///   <remarks>It must be M to move forward, L to turn left, or R to turn right.</remarks>
    /// </param>
    private void ExecuteMove(Grid map, char move) {
      switch (move) {
        case 'M':
          MoveForward(map);
          break;
        case 'L':
          TurnLeft();
          break;
        case 'R':
          TurnRight();
          break;
      }
    }

    /// <summary>
    /// Executes a list of moves.
    /// </summary>
    /// <param name="map">The grid instance which represents a rectangle area.</param>
    /// <param name="moves">A list which contains the moves to be done.
    ///   <remarks>Each move must be M to move forward, L to turn left, or R to turn right.</remarks>
    /// </param>
    public void ExecuteMoves(Grid map, List<char> moves) {
      moves.ForEach(move => ExecuteMove(map, move));
    }

    /// <summary>
    /// Gets the string representation for a drone instance.
    /// </summary>
    /// <returns></returns>
    public override string ToString() {
      return $"{mPositionX} {mPositionY} {mDirection}";
    }
  }
}