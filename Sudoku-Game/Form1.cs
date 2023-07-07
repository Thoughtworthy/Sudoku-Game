using Sudoku_Game.Button_Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using Sudoku_Game.LoggInfo;
using System.Linq;
using System.Windows.Forms;

namespace Sudoku_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            createCells();
            startNewGame();
            Losses.Text = $"Total Losses - {LoggInfo.LoggInfo.GetTotalLost().ToString()}";
            Wins.Text = $"Total Wins - {LoggInfo.LoggInfo.GetTotalWins().ToString()}";
        }

        static int tryes; 
        private SudokuCell[,] cells = new SudokuCell[9, 9];
        Random random = new Random();
        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(80, 80);
                    cells[i, j].ForeColor = Color.Black;
                    cells[i, j].Location = new Point(i * 80, j * 80);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // Assign key press event for each cells
                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
        }

        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;

            // Do nothing if the cell is locked
            if (cell.IsLocked)
                return;

            int value;

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();

                cell.ForeColor = Color.Black;
            }
        }
        private void startNewGame()
        {
            loadValues();

            var hintsCount = 0;

            // Assign the hints count based on the 
            // level player chosen
            if (beginnerLevel.Checked)
            {
                tryes = 3;
                hintsCount = 50;
            }
            else if (IntermediateLevel.Checked)
            {
                tryes = 2;
                hintsCount = 30;
            }
            else if (AdvancedLevel.Checked)
            {
                tryes = 1;
                hintsCount = 15;
            }
            else
            {
                tryes = 3;
                beginnerLevel.Checked = true;
                hintsCount = 50;
            }

            showRandomValuesHints(hintsCount);
        }
        private void showRandomValuesHints(int hintsCount)
        {
            // Show value in random cells
            // The hints count is based on the level player choose
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                // Style the hint cells differently and
                // lock the cell so that player can't edit the value
                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }
        private void loadValues()
        {
            // Clear the values in each cells
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            // This method will be called recursively 
            // until it finds suitable values for each cells
            findValueForNextCell(0, -1);
        }



        private bool findValueForNextCell(int i, int j)
        {
            //Increment the i and j values to move to the next cell
            // and if the columsn ends move to the next row
            if (++j > 8)
            {
                j = 0;

                // Exit if the line ends
                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Find a random and valid number for the cell and go to the next cell 
            // and check if it can be allocated with another random and valid number
            do
            {
                // If there is not numbers left in the list to try next, 
                // return to the previous cell and allocate it with a different number
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                // Take a random number from the numbers left in the list
                value = numsLeft[random.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                // Remove the allocated value from the list
                numsLeft.Remove(value);
            }
            while (!isValidNumber(value, i, j) || !findValueForNextCell(i, j));

            // TODO: Testing Values
            //cells[i, j].Text = value.ToString();

            return true;
        }

        private bool isValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                // Check all the cells in vertical direction
                if (i != y && cells[x, i].Value == value)
                    return false;

                // Check all the cells in horizontal direction
                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            // Check all the cells in the specific block
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void CheckInput_Click(object sender, EventArgs e)
        {
            var wrongCells = new List<SudokuCell>();

            // Find all the wrong inputs
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }

            // Check if the inputs are wrong or the player wins 
            if (wrongCells.Any())
            {
                // Highlight the wrong inputs 
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong inputs");
                tryes--;
                if (tryes == 0)
                {
                   // LoggInfo.LoggInfo.FillInfo(int.Parse(Losses.Text)+ 1, int.Parse(Wins.Text));
                    //Losses.Text = $"Total Losses - {LoggInfo.LoggInfo.GetTotalLost().ToString()}";

                    startNewGame();
                }
            }
            else
            {
                //LoggInfo.LoggInfo.FillInfo(int.Parse(Losses.Text), int.Parse(Wins.Text) + 1);
                Console.Beep();
                Console.Beep();
                Console.Beep();
                MessageBox.Show("You Wins");
               // Wins.Text = $"Total Wins - {LoggInfo.LoggInfo.GetTotalWins().ToString()}";
            }
        }

        private void ClearInput_Click(object sender, EventArgs e)
        {
            foreach (var cell in cells)
            {
                // Clear the cell only if it is not locked
                if (cell.IsLocked == false)
                    cell.Clear();
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            startNewGame();
        }
    }
}
