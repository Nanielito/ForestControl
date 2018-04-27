using Xunit;

namespace ForestControl.test {
 
  /// <summary>
  /// The drone test class for unit testing.
  /// </summary>
  public class DroneTest {

    #region Constructor
    
    [Fact]
    public void DroneMustContainsTheSameParametersAfterCreation() {
      int positionX = 3;
      int positionY = 5;
      char direction = 'N';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      Assert.Equal(positionX, drone.GetPositionX());
      Assert.Equal(positionY, drone.GetPositionY());
      Assert.Equal(direction, drone.GetDirection());
    }
    
    #endregion

    #region DirectionNorth
    
    [Fact]
    public void DroneGoingToNorthMustNotChangePositionAfterMovingToAnInvalidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 0;
      int positionY = 5;
      char direction = 'N';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionX, drone.GetPositionX());
      Assert.Equal(positionY, drone.GetPositionY());
    }
    
    [Fact]
    public void DroneGoingToNorthMustChangePositionAfterMovingToAValidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 0;
      int positionY = 3;
      char direction = 'N';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionX, drone.GetPositionX());
      Assert.NotEqual(positionY, drone.GetPositionY());
      Assert.Equal(positionY + 1, drone.GetPositionY());
    }
    
    [Fact]
    public void DroneGoingNorthMustDirectToSameDirectionAfterMovingForward() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 2;
      int positionY = 2;
      char direction = 'N';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(direction, drone.GetDirection());
    }
    
    [Fact]
    public void DroneGoingToNorthMustDirectToWestAfterTurnLeft() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'N';
      char expected = 'W';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnLeft();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
    
    [Fact]
    public void DroneGoingToNorthMustDirectToEastAfterTurnRight() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'N';
      char expected = 'E';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnRight();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
    
    #endregion
    
    #region DirectionEast
    
    [Fact]
    public void DroneGoingToEastMustNotChangePositionAfterMovingToAnInvalidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 5;
      int positionY = 0;
      char direction = 'E';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionX, drone.GetPositionX());
      Assert.Equal(positionY, drone.GetPositionY());
    }
    
    [Fact]
    public void DroneGoingToEastMustChangePositionAfterMovingToAValidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 3;
      int positionY = 0;
      char direction = 'E';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionY, drone.GetPositionY());
      Assert.NotEqual(positionX, drone.GetPositionX());
      Assert.Equal(positionX + 1, drone.GetPositionX());
    }
    
    [Fact]
    public void DroneGoingEastMustDirectToSameDirectionAfterMovingForward() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 2;
      int positionY = 2;
      char direction = 'E';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(direction, drone.GetDirection());
    }
        
    [Fact]
    public void DroneGoingToEastMustDirectToNorthAfterTurnLeft() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'E';
      char expected = 'N';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnLeft();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
    
    [Fact]
    public void DroneGoingToEastMustDirectToSouthAfterTurnRight() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'E';
      char expected = 'S';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnRight();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
        
    #endregion
    
    #region DirectionSouth
    
    [Fact]
    public void DroneGoingToSouthMustNotChangePositionAfterMovingToAnInvalidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 0;
      int positionY = 0;
      char direction = 'S';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionX, drone.GetPositionX());
      Assert.Equal(positionY, drone.GetPositionY());
    }
    
    [Fact]
    public void DroneGoingToSouthMustChangePositionAfterMovingToAValidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 0;
      int positionY = 1;
      char direction = 'S';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionX, drone.GetPositionX());
      Assert.NotEqual(positionY, drone.GetPositionY());
      Assert.Equal(positionY - 1, drone.GetPositionY());
    }
    
    [Fact]
    public void DroneGoingSouthMustDirectToSameDirectionAfterMovingForward() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 2;
      int positionY = 2;
      char direction = 'S';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(direction, drone.GetDirection());
    }
    
    [Fact]
    public void DroneGoingToSouthMustDirectToEastAfterTurnLeft() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'S';
      char expected = 'E';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnLeft();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
    
    [Fact]
    public void DroneGoingToSouthMustDirectToWestAfterTurnRight() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'S';
      char expected = 'W';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnRight();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
    
    #endregion
    
    #region DirectionWest
    
    [Fact]
    public void DroneGoingToWestMustNotChangePositionAfterMovingToAnInvalidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 0;
      int positionY = 0;
      char direction = 'W';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionX, drone.GetPositionX());
      Assert.Equal(positionY, drone.GetPositionY());
    }
    
    [Fact]
    public void DroneGoingToWestMustChangePositionAfterMovingToAValidPosition() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 1;
      int positionY = 0;
      char direction = 'W';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(positionY, drone.GetPositionY());
      Assert.NotEqual(positionX, drone.GetPositionX());
      Assert.Equal(positionX - 1, drone.GetPositionX());
    }
    
    [Fact]
    public void DroneGoingWestMustDirectToSameDirectionAfterMovingForward() {
      int maxRangeX = 5;
      int maxRangeY = 5;
      int positionX = 2;
      int positionY = 2;
      char direction = 'W';
      
      Grid map = new Grid(maxRangeX, maxRangeY);
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.MoveForward(map);
      
      Assert.Equal(direction, drone.GetDirection());
    }
    
    [Fact]
    public void DroneGoingToWestMustDirectToSouthAfterTurnLeft() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'W';
      char expected = 'S';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnLeft();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
    
    [Fact]
    public void DroneGoingToWestMustDirectToNorthAfterTurnRight() {
      int positionX = 2;
      int positionY = 2;
      char direction = 'W';
      char expected = 'N';
      
      Drone drone = new Drone(positionX, positionY, direction);
      
      drone.TurnRight();
      
      Assert.NotEqual(direction, drone.GetDirection());
      Assert.Equal(expected, drone.GetDirection());
    }
    
    #endregion
  }
}