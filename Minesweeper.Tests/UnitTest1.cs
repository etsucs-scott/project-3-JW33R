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
    }
}