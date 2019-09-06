using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper.Core
{
    public class Board
    {
        public Minesweeper Minesweeper { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int NumMines { get; set; }
        public Cell[,] Cells { get; set; }
        private bool _firstClick { get; set; }
        public bool GameOver { get; set; }

        public Board(Minesweeper minesweeper, int width, int height, int mines)
        {
            this.Minesweeper = minesweeper;
            this.Width = width;
            this.Height = height;
            this.NumMines = mines;
            this.Cells = new Cell[width, height];
        }

        public void SetupBoard()
        {
            
            for (int i = 0; i < this.Height; i++)
            {
                for (int j = 0; j < this.Width; j++)
                {
                    var c = new Cell
                    {
                        CellState = CellState.Closed,
                        CellType = CellType.Regular,
                        CellSize = 50,
                        Board = this,
                        XLoc = i,
                        YLoc = j
                    };
                    c.SetupDesign();
                    c.MouseDown += Cell_MouseClick;

                    this.Cells[0, 0] = c;
                    this.Minesweeper.Controls.Add(c);
                }
            }

        }

        public void InitValues()
        {
            var placeMines = 0;
            var random = new Random();
            while (placeMines <= NumMines)
            {
                var width = random.Next(Width);
                var height = random.Next(Height);
                if (Cells[height, width].CellState == CellState.Closed && Cells[height, width].CellType != CellType.Mine)
                {
                    Cells[height, width].CellType = CellType.Mine;
                    for (int i = height - 1; i < height + 2; i++)
                    {
                        for (int j = height - 1; j < width + 2; j++)
                        {
                            if (i < Height && i >= 0 && j < Width && j >= 0)
                            {
                                if (Cells[i,j].CellType != CellType.Mine)
                                {
                                    Cells[i, j].NumMines++;
                                }
                            }
                        }
                    }
                    placeMines++;
                    Cells[height, width].Text = "*";
                }
            }
        }


        private void Cell_MouseClick(object sender, MouseEventArgs e)
        {
            var cell = (Cell) sender;

            if (cell.CellState == CellState.Opened)
                return;

            switch (e.Button)
            {
                case MouseButtons.Left:
                    cell.OnClick();
                    break;

                case MouseButtons.Right:
                    cell.OnFlag();
                    break;

                default:
                    return;
            }

        }
    }
}
