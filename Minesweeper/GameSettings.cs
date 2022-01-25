using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class GameSettings
    {
        public int BoardRow { get; set; }
        public int BoardCol { get; set; }
        public int Mines { get; set; }
    }

    

    public class Constants
    { 
        public static readonly List<int> BOARD_ROW_SIZES = new() { 10, 15, 18, 20, 25, 30 };
        public static readonly List<int> BOARD_COL_SIZES = new() { 10, 15, 18, 20, 25, 30 };
        public static readonly List<int> MINES = new() { 15, 20, 25, 30, 40, 50, 60, 70, 80, 90 };

        public const string DIGIT_1 = "1";
        public const string DIGIT_2 = "2";
        public const string DIGIT_3 = "3";
        public const string DIGIT_4 = "4";
        public const string DIGIT_5 = "5";
        public const string DIGIT_6 = "6";
        public const string DIGIT_7 = "7";
        public const string DIGIT_8 = "8";
        public const string FLAG = "F";
        public const string MINE_EXPLODE = "ME";
        public const string MINE = "M";
        public const string HAPPY = "H";
        public const string SAD = "S";



        public static Image GetResource(string val)
        {
            return val switch
            {
                DIGIT_1 => Properties.Resources.Digit_1,
                DIGIT_2 => Properties.Resources.Digit_2,
                DIGIT_3 => Properties.Resources.Digit_3,
                DIGIT_4 => Properties.Resources.Digit_4,
                DIGIT_5 => Properties.Resources.Digit_5,
                DIGIT_6 => Properties.Resources.Digit_6,
                DIGIT_7 => Properties.Resources.Digit_7,
                DIGIT_8 => Properties.Resources.Digit_8,
                FLAG => Properties.Resources.flag,
                MINE_EXPLODE => Properties.Resources.mine_explode,
                MINE => Properties.Resources.mine,
                HAPPY => Properties.Resources.happy,
                SAD => Properties.Resources.sad,
                _ => throw new NotImplementedException()
            };
        }
    }
    public class MineSweeperBoxLocation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MineSweeperBoxLocation(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            return Equals((MineSweeperBoxLocation)obj);
        }

        public bool Equals(MineSweeperBoxLocation other)
        {
            return other != null &&
                   X == other.X &&
                   Y == other.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }
    }
}
