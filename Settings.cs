using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    internal class Settings
    {
        public static int pixelWidth { get; private set; }
        public static int pixelHeight { get; private set; }
        public static int Total { get; set; }
        public static int Point { get; private set; }
        public static bool gameOver { get; set; }
        public static Directions Direction { get; set; }
        public static int maxXpos { get; set; }
        public static int maxYpos { get; set; }
        public static bool specialApple { get; set;}

        public Settings()
        {
            pixelWidth = 20;
            pixelHeight = 20;
            Total = 0;
            Point = 1;
            gameOver = false;
            Direction = Directions.R;
            maxXpos = 0;
            maxYpos = 0;
            specialApple = false;
        }
    }

    public enum Directions
    {
        U, D, L, R
    };
}
