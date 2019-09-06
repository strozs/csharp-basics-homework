using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minesweeper.Core;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Minesweeper.Tests
{
    [TestClass]
    public class BoardTests
    {
        [Fact]
        public void TestMethod1()
        {
            var board = new Board(new Minesweeper(), 50, 50, 10);
            board.Height.Should().Be(50);
            board.Width.Should().Be(50);
            board.NumMines.Should().Be(10);
        }

        [Fact]
        public void Board_FilledTest()
        {
            var board = new Board(new Minesweeper(), 9, 9, 5);
            board.SetupBoard();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Xunit.Assert.NotNull(board.Cells[i,j]);
                }
            }
        }

        [Fact]
        public void Board_CellLocation_Test()
        {
            var board = new Board(new Minesweeper(), 9, 9, 5);
            board.SetupBoard();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    board.Cells[i, j].XLoc.Should().Be(i);
                    board.Cells[i, j].YLoc.Should().Be(j);
                }
            }
        }

        [Fact]
        public void Board_CellClickTest()
        {
            var board = new Board(new Minesweeper(), 9, 9, 5);
            board.SetupBoard();
            var cell = board.Cells[0, 5];
            var cell2 = board.Cells[4, 5];
            cell.OnClick();
            cell.CellState.Should().Be(CellState.Opened);
            cell2.OnClick();
            cell2.CellState.Should().Be(CellState.Opened);
        }

        [Fact]
        public void Board_MineCount()
        {
            var board = new Board(new Minesweeper(), 9, 9, 5);
            board.SetupBoard();
            var rnd = new Random();//

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board.Cells[i, j].CellType == CellType.Mine)
                    {
                        
                    }
                }
            }
        }

        [Fact]
        public void Board_NumberTest()
        {
            var board = new Board(new Minesweeper(), 9, 9, 5);
            board.SetupBoard();
            var rnd = new Random();
            var height = rnd.Next(board.Height);
            var width = rnd.Next(board.Width);
            var cell = board.Cells[height, width];
            cell.OnClick();
            board.InitValues();

            for (int i = 0; i < board.Height; i++)
            {
                for (int j = 0; j < board.Width; j++)
                {
                    if (board.Cells[i, j].CellType == CellType.Mine)
                    {
                        for (int k = i - 1; k < i + 2; k++)
                        {
                            for (int l = j - 1; l < j + 2; l++)
                            {
                                if (k < board.Height && k >= 0 && l < board.Width && l >= 0)
                                {
                                    if (board.Cells[k,l].CellType == CellType.Mine)
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        board.Cells[k, l].NumMines.Should().BeGreaterThan(0);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        [Fact]
        public void Board_GameOverTest()
        {
            var board = new Board(new Minesweeper(), 9, 9, 5);
            board.SetupBoard();
            var rnd = new Random();
            var cell = board.Cells[1, 1];
            cell.CellType = CellType.Mine;
            


        }
    }
}
