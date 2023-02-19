using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class MineSweeperButton : Button
    {
        public bool IsMine { get; set; }
        public MineSweeperBoxLocation BoxLocation { get; set; }

        private const int ButtonHeight = 40;
        private const int ButtonWidth = 40;

        public MineSweeperButton(MineSweeperBoxLocation location, 
            bool isMine, 
            Color foreColor, 
            Color backColor, 
            Color borderColor)
        {
            BoxLocation = location;
            IsMine = isMine;
            Top = location.X * ButtonHeight;
            Left = location.Y * ButtonWidth;
            Width = ButtonWidth;
            Height = ButtonHeight;
            ForeColor = foreColor;
            BackColor = backColor;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = borderColor;
            TabStop = false;
        }
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }

    }
}
