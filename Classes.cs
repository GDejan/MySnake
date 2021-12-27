using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MySnake
{
    class Item
    {
        public int x { get; set; }
        public int y { get; set; }
        public Item()
        {
            x = 0;
            y = 0;
        }
    }

    class Input
    {
        private static Hashtable keyTable = new Hashtable();
        public static bool Keyboard(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }
        public static void Pressed(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }

    public enum Directions
    {
        U, D, L, R
    };

    class Settings
    {
        public static int pixelWidth { get; set; }
        public static int pixelHeight { get; set; }
        public static int snakeSpeed { get; set; }
        public static int Total { get; set; }
        public static int Point { get; set; }
        public static bool gameOver { get; set; }
        public static Directions Direction { get; set; }

        public Settings()
        {
            pixelWidth = 20;
            pixelHeight = 20;
            snakeSpeed = 10;
            Total = 0;
            Point = 1;
            gameOver = false;
            Direction = Directions.R;
        }
    }
    
}