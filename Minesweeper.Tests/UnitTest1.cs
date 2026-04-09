using Minesweeper.Core;
using Minesweeper.Cli;
namespace Minesweeper.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestBombAmount()
        {
            Maze maze = new Maze();

            var result = maze.BombAmount(8);

            Assert.Equal(10, result);
        }
        [Fact]
        public void TestNullBombAmount()
        {
            var maze = new Maze();

            var result = maze.BombAmount(0);

            Assert.Equal(0, result);
        }
        [Fact]
        public void TestMazeSize()
        {
            var maze = new Maze();

            var result = maze.MazeSize(1);

            Assert.Equal(8, result);
        }
        [Fact]
        public void TestNullMazeSize()
        {
            var maze = new Maze();

            var result = maze.MazeSize(0);

            Assert.Equal(0, result);
        }
        [Fact]
        public void TestCheckWin()
        {
            var gameEngine = new GameEngine();

            for (int i = 0; i < 54; i++)
            {
                gameEngine.IncreaseRevealedCells();
            }
            gameEngine.CheckWin(8, 10);

            Assert.True(gameEngine.Won);
        }
        [Fact]
        public void CheckLost()
        {
            var gameEngine = new GameEngine();

            gameEngine.Maze.GenerateMaze(8, 10);
            gameEngine.Maze.MineSweeperMaze[0,0].PlaceMine();
            gameEngine.BFSGrid(gameEngine.Maze.MineSweeperMaze, 0, 0);

            Assert.True(gameEngine.Lost);
        }
        [Fact]
        public void CheckBoardGenerationFor10()
        {
            var gameEngine = new GameEngine();

            gameEngine.Maze.GenerateMaze(8, 10);

            Assert.Equal(64, gameEngine.Maze.MineSweeperMaze.Length);
        }
        [Fact]
        public void CheckBoardGenerationFor12()
        {
            var gameEngine = new GameEngine();

            gameEngine.Maze.GenerateMaze(12, 10);

            Assert.Equal(144, gameEngine.Maze.MineSweeperMaze.Length);

        }
        [Fact]
        public void CheckSavingFile()
        {
            var fileHandling = new FileHandling();

            fileHandling.SaveGame(8, 120, 15, 123, "1/3/2024");

            Assert.True(File.Exists("minesweeper_save.csv"));

        }
        [Fact]
        public void CheckLoadingNullFile()
        {
            var fileHandling = new FileHandling();

            File.Delete("minesweeper_save.csv");
            var result = fileHandling.LoadGame();

            Assert.Null(result);
        }
    }
}