using System.Windows.Forms;


namespace Sudoku_Game.Button_Class
{
    internal class SudokuCell : Button
    {
        public int Value { get; set; }
        public bool IsLocked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            Text = string.Empty;
            IsLocked = false;
        }
    }
}
