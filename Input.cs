using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    public class Input
    {
        private static Hashtable keyTable = new Hashtable();

        /// <summary>
        /// keyboard input empty constructor
        /// </summary>
        public Input()
        {

        }

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
}
