using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    internal class MineSweeperReveal
    {
        public static int[][] neighbors =
        {
            new int[]{1, 0},
            new int[]{0, 1},
            new int[]{-1, 0},
            new int[]{0, -1},
            new int[]{1, 1},
            new int[]{-1,-1},
            new int[]{1, -1},
            new int[]{-1, 1}
        };
        public static void UpdateButtons(List<MineSweeperButton> buttons, int row, int col, MineSweeperBoxLocation current)
        {
            bool[,] visited = new bool[row,col];
 
            UpdateBoard(buttons, current.X, current.Y, visited, row, col);
        }

        private static void UpdateBoard(List<MineSweeperButton> buttons, int i, int j, bool[,] visited, int row, int col)
        {
            if (IsOutOfBounds(i, j, row, col) || visited[i, j])
            {
                return;
            }
            visited[i, j] = true;

            MineSweeperButton? button = buttons.Find(x => x.BoxLocation.Equals(new MineSweeperBoxLocation(i, j)));
            if(button == null)
            {
                return ;
            }

            int adjacentMines = GetNumberOfAdjacentMineNeighbors(buttons, i, j, row, col);
            
            if (adjacentMines > 0)
            {
                OnClickChange(button, Constants.GetResource(adjacentMines.ToString()));
            }
            else
            {
                OnClickChange(button, null);
            }

            if (button.BackgroundImage != null)
            {
                return;
            }

            for (int k = 0; k < neighbors.GetLength(0); k++)
            {
                int[] neightbor = neighbors[k];
                UpdateBoard(buttons, i + neightbor[0], j + neightbor[1], visited, row, col);
            }
        }

        private static int GetNumberOfAdjacentMineNeighbors(List<MineSweeperButton> buttons, int i, int j, int row, int col)
        {
            int numberOfAdjacentMines = 0;
            foreach (int[] neighbor in neighbors)
            {
                int neighborI = i + neighbor[0];
                int neighborJ = j + neighbor[1];
                if (!IsOutOfBounds(neighborI, neighborJ, row, col))
                {
                    MineSweeperButton? button = buttons.Find(x => x.BoxLocation.Equals(new MineSweeperBoxLocation(neighborI, neighborJ)));
                    if (button != null && button.IsMine)
                    {
                        numberOfAdjacentMines++;
                    }
                }
            }
            return numberOfAdjacentMines;
        }

        internal static void OnRightClickChange(MineSweeperButton mineSweeperButton, Image image)
        {
            if (mineSweeperButton == null)
            {
                return;
            }
            mineSweeperButton.BackgroundImage = image ?? mineSweeperButton.BackgroundImage;
            mineSweeperButton.BackgroundImageLayout = ImageLayout.Center;
        }

        private static bool IsOutOfBounds(int i, int j, int iLength, int jLength)
        {
            return i < 0 || j < 0 || i >= iLength || j >= jLength;
        }

        public static void RevealAllMines(List<MineSweeperBoxLocation> mineLocations, 
            List<MineSweeperButton> buttons,
            MineSweeperBoxLocation current)
        {
            foreach (MineSweeperBoxLocation mineSweeperBoxLocation in mineLocations)
            {
                MineSweeperButton? button = buttons.Find(x => x.BoxLocation.Equals(mineSweeperBoxLocation));
                if (!mineSweeperBoxLocation.Equals(current))
                {
                    OnClickChange(button, Constants.GetResource(Constants.MINE));
                }
                else
                {
                    OnClickChange(button, Constants.GetResource(Constants.MINE_EXPLODE));
                }
            }
        }


        public static void OnClickChange(MineSweeperButton? mineSweeperButton, Image? background)
        {
            if (mineSweeperButton == null)
            {
                return;
            }
            FontFamily fontFamily = new("Arial");
            mineSweeperButton.Enabled = false;
            mineSweeperButton.BackColor = Color.LightGray;
            mineSweeperButton.Font = new Font(
               fontFamily,
               12,
               FontStyle.Bold,
               GraphicsUnit.Pixel);
            mineSweeperButton.BackgroundImage = background ?? mineSweeperButton.BackgroundImage;
            mineSweeperButton.BackgroundImageLayout = ImageLayout.Center;
            mineSweeperButton.FlatAppearance.MouseDownBackColor = Color.LightGray;
        }

        public static bool DidGameEnd(List<MineSweeperButton> buttons, int numberOfMines)
        {
            int count = buttons.FindAll(x => x.Enabled).Count;
            return numberOfMines == count && count != 0;
        }
    }
}
