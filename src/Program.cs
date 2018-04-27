using System;
using System.IO;
using System.Linq;

namespace ForestControl {
 
  /// <summary>
  /// Main application executable class.
  /// </summary>
  class Program {
    
    private static readonly string TEST_CASES_ROOT_PATH = Path.Combine("src", "resources", "testCases"); 

    /// <summary>
    /// Gets the test case files located into <code>TEST_CASES_ROOT_PATH</code>.
    /// </summary>
    /// <returns>An array which contains paths to each test case file.</returns>
    static string[] GetTestCases() {
      string currentDirectory = Environment.CurrentDirectory;
      string testCasesDirectory = Path.Combine(currentDirectory, TEST_CASES_ROOT_PATH);
      
      return Directory.GetFiles(testCasesDirectory, "*.txt");
    }

    /// <summary>
    /// Executes a test case.
    /// </summary>
    /// <param name="testCaseFilePath">The test case file path.</param>
    static void ExecuteTestCase(string testCaseFilePath) {
      using (StreamReader streamReader = File.OpenText(testCaseFilePath)) {
        string input = streamReader.ReadLine();
        string[] data = input.Split(" ");
        Grid map = new Grid(int.Parse(data[0]), int.Parse(data[1]));
        Drone drone = new Drone();
        char[] moves;
        
        while ((input = streamReader.ReadLine()) != null) {
          data = input.Split(" ");
          
          drone.SetPositionX(int.Parse(data[0]));
          drone.SetPositionY(int.Parse(data[1]));
          drone.SetDirection(char.Parse(data[2]));

          input = streamReader.ReadLine();
          moves = input.ToCharArray();
          
          drone.ExecuteMoves(map, moves.ToList());
          
          Console.WriteLine(drone.ToString());
        }
      }
    }

    /// <summary>
    /// The main application entry point.
    /// </summary>
    /// <param name="args">The application arguments.</param>
    static void Main(string[] args) {
      string[] testCases = GetTestCases();
      
      Array.ForEach(testCases, ExecuteTestCase);
    }
  }
}