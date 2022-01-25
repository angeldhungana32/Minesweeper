using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{

    public partial class GameInfo : Form
    {
        public GameSettings GameSettings = new();
        public GameInfo()
        {
            InitializeComponent();
            BoardRowCombo.DataSource = Constants.BOARD_ROW_SIZES;
            BoardColCombo.DataSource = Constants.BOARD_COL_SIZES;
            MinesCombo.DataSource = Constants.MINES;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            GameSettings.BoardRow = (int)BoardRowCombo.SelectedItem;
            GameSettings.BoardCol = (int)BoardColCombo.SelectedItem;
            GameSettings.Mines = (int)MinesCombo.SelectedItem;
            this.Close();
        }
    }
}
