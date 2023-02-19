namespace Minesweeper
{
    public partial class Minesweeper : Form
    {
        private List<MineSweeperButton> buttonList;
        private GameSettings gameSettings;
        private GameInfo gameInfo = new();
        private List<MineSweeperBoxLocation> mineLocations;
        public Minesweeper()
        {
            buttonList = new List<MineSweeperButton>();
            gameSettings = new GameSettings();
            mineLocations = new List<MineSweeperBoxLocation>();

            InitializeComponent();
            gameInfo.ShowDialog();
            OnLoad();
        }

        private void OnLoad()
        {
            gameSettings = gameInfo.GameSettings;

            SetResetButton(Constants.HAPPY);

            this.minesweeperPanel.Enabled = true;
            this.minesweeperPanel.Controls.Clear();
            this.NumOfMines.Text = gameSettings.Mines.ToString().PadLeft(3, '0');
            
            mineLocations = GenerateRandomMineLocations(gameSettings.Mines, 
                gameSettings.BoardRow, 
                gameSettings.BoardCol);

            InitializeBoard(gameSettings.BoardRow, 
                gameSettings.BoardCol, 
                mineLocations);
        }

        private void InitializeBoard(int row, int column, List<MineSweeperBoxLocation> mines)
        {
            buttonList = new List<MineSweeperButton>();

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < column; y++)
                {
                    MineSweeperBoxLocation location = new(x, y);

                    MineSweeperButton button = new(location,
                        mines.Contains(location), 
                        Color.White, 
                        Color.Black, 
                        Color.White);

                    button.MouseUp += (s, args) =>
                    {
                        if (args.Button == MouseButtons.Right)
                        {
                            OnMineSweeperRightButtonClicked(s, args);
                        }
                        else
                        {
                            OnMineSweeperButtonClicked(s,args);
                        }
                    };

                    minesweeperPanel.Controls.Add(button);
                    buttonList.Add(button);
                }
            }
        }

        private void OnMineSweeperRightButtonClicked(object s, MouseEventArgs args)
        {
            MineSweeperButton mineSweeperButton = (MineSweeperButton)s;

            MineSweeperReveal.OnRightClickChange(mineSweeperButton, 
                Constants.GetResource(Constants.FLAG));
        }

        private static List<MineSweeperBoxLocation> GenerateRandomMineLocations(int numberOfMines, 
            int rows, 
            int cols)
        {
            List<MineSweeperBoxLocation> locations = new();
            Random rng  = new();

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    locations.Add(new MineSweeperBoxLocation(i, j));
                }
            }

            List<MineSweeperBoxLocation> shuffledLocations = locations
                .OrderBy(a => rng.Next())
                .ToList();

            return shuffledLocations
                .Take(numberOfMines)
                .ToList();
        }

        private void OnMineSweeperButtonClicked(object sender, EventArgs args)
        {
            MineSweeperButton mineSweeperButton = (MineSweeperButton)sender;
            if (mineSweeperButton.IsMine)
            {
                MineSweeperReveal.RevealAllMines(mineLocations, 
                    buttonList, 
                    mineSweeperButton.BoxLocation);

                SetResetButton(Constants.SAD);
            }
            else
            {
                MineSweeperReveal.UpdateButtons(buttonList, 
                    gameSettings.BoardRow, 
                    gameSettings.BoardCol, 
                    mineSweeperButton.BoxLocation);
            }

            if(MineSweeperReveal.DidGameEnd(buttonList, gameSettings.Mines))
            {
                MessageBox.Show("You won!", 
                    "WOOOOOOOO",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            gameInfo.ShowDialog();
            OnLoad();
        }

        private void Exit_Game_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetResetButton(string imgType)
        {
            this.minesweeperPanel.Enabled = imgType == Constants.HAPPY;
            this.ResetPanel.Enabled = imgType == Constants.SAD;
            this.ResetPanel.FlatStyle = FlatStyle.Flat;
            this.ResetPanel.FlatAppearance.BorderSize = 0;
            this.ResetPanel.TabStop = false;
            this.ResetPanel.BackgroundImage = Constants.GetResource(imgType);
            this.ResetPanel.BackgroundImageLayout = ImageLayout.Center;
        }

        private void ResetPanel_Click(object sender, EventArgs e)
        {
            OnLoad();
        }
    }
}