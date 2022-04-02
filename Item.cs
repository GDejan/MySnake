using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MySnake
{
    public class Item
    {
        public int x { get; set; }
        public int y { get; set; }

        public Item()
        {

        }
        public Item(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }
    
}