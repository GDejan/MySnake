using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace MySnake
{
   
    public partial class Form1 : Form
    {
        Random random = new Random();
        private List<Item> Tale = new List<Item>();
        private Item Apple = new Item();
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
           
            new Settings();
            timer.Interval = 150;
            timer.Tick += readInput;
            timer.Start();
            
            this.Text = ("Welcome "+ Environment.UserName+ ". Thanks for playing ;)");
            startGame();
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            Input.Pressed(e.KeyCode, true);
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            Input.Pressed(e.KeyCode, false);
        }

        private void startGame()
        {
            new Settings();
            gameOwer.Visible = false;
            Total.Visible = true;

            Settings.maxXpos = gameWindow.Size.Width / Settings.pixelWidth;
            Settings.maxYpos = gameWindow.Size.Height / Settings.pixelHeight;
            
            Tale.Clear();
            Item head = new Item { x = 10, y = 10 };
            Tale.Add(head);
            Total.Text = "Total " + Settings.Total.ToString();
            newApple();
        }

        private void readInput(object sender, EventArgs e)
        {
            if (Input.Keyboard(Keys.Escape))
            {
                Close();
            }
            if (Settings.gameOver == true)
            {
                string gameOver = "Game Over\n" + "Total is: " + Settings.Total + "\nEnter to Restart";
                gameOwer.Text = gameOver;
                gameOwer.Visible = true;
                Total.Visible = false;

                if (Input.Keyboard(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                if (Input.Keyboard(Keys.Right) && Settings.Direction != Directions.L)
                {
                    Settings.Direction = Directions.R;
                }
                else if (Input.Keyboard(Keys.Left) && Settings.Direction != Directions.R)
                {
                    Settings.Direction = Directions.L;
                }
                else if (Input.Keyboard(Keys.Up) && Settings.Direction != Directions.D)
                {
                    Settings.Direction = Directions.U;
                }
                else if (Input.Keyboard(Keys.Down) && Settings.Direction != Directions.U)
                {
                    Settings.Direction = Directions.D;
                }
                moveSnake(Tale, Apple);
            }
            gameWindow.Invalidate();
        }

        public void newApple()
        {
            int x = random.Next(0, Settings.maxXpos);
            int y = random.Next(0, Settings.maxYpos);

            Apple = new Item(x, y);

            for (int i = Tale.Count - 1; i >= 0; i--)
            {
                if (Tale[i].x == Apple.x && Tale[i].y == Apple.y)
                {
                    Apple = new Item { x = random.Next(0, Settings.maxXpos), y = random.Next(0, Settings.maxYpos) };
                }
            }
        }

        public void eat()
        {
            Item body = new Item
            {
                x = Tale[Tale.Count - 1].x,
                y = Tale[Tale.Count - 1].y
            };

            Tale.Add(body);
            Settings.Total += Settings.Point;
            if (Settings.specialApple)
            {
                Settings.Total += Settings.Point;
                Settings.specialApple = false;
            }
            Total.Text = "Total: " + Settings.Total.ToString();
            newApple();
        }

        public void moveSnake(List<Item> Tale, Item Apple)
        {
            for (int i = Tale.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.Direction)
                    {
                        case Directions.R:
                            Tale[i].x++;
                            break;
                        case Directions.L:
                            Tale[i].x--;
                            break;
                        case Directions.U:
                            Tale[i].y--;
                            break;
                        case Directions.D:
                            Tale[i].y++;
                            break;
                    }

                    if (Tale[i].x < 0 || Tale[i].y < 0 || Tale[i].x > Settings.maxXpos - 1 || Tale[i].y > Settings.maxYpos - 1)
                    {
                        collision();
                    }

                    for (int j = 1; j < Tale.Count; j++)
                    {
                        if (Tale[i].x == Tale[j].x && Tale[i].y == Tale[j].y)
                        {
                            collision();
                        }
                    }

                    if (Tale[0].x == Apple.x && Tale[0].y == Apple.y)
                    {
                        eat();
                    }
                }
                else
                {
                    Tale[i].x = Tale[i - 1].x;
                    Tale[i].y = Tale[i - 1].y;
                }
            }
        }

        private void collision()
        {
            Settings.gameOver = true;
        }


        private void paintGraphics(object sender, PaintEventArgs e)
        {
            Graphics gameWindow = e.Graphics;

            if (Settings.gameOver == false)
            {
                Brush snakeColour;
                for (int i = 0; i < Tale.Count; i++)
                {
                    if (i == 0)
                    {
                        snakeColour = Brushes.Black;
                    }
                    else
                    {
                        snakeColour = Brushes.Gray;
                    }
                  
                    gameWindow.FillRectangle(snakeColour,
                                         new Rectangle(
                                             Tale[i].x * Settings.pixelWidth,
                                             Tale[i].y * Settings.pixelHeight,
                                             Settings.pixelWidth, Settings.pixelHeight
                                             ));

                    if ((Settings.Total % 10) == 0 && (Settings.Total>0))
                    {
                        gameWindow.FillEllipse(Brushes.Gold,
                                        new Rectangle(
                                            Apple.x * Settings.pixelWidth,
                                            Apple.y * Settings.pixelHeight,
                                            Settings.pixelWidth, Settings.pixelHeight
                                            ));
                        Settings.specialApple = true;
                    }
                    else 
                    {
                        gameWindow.FillEllipse(Brushes.Red,
                                        new Rectangle(
                                            Apple.x * Settings.pixelWidth,
                                            Apple.y * Settings.pixelHeight,
                                            Settings.pixelWidth, Settings.pixelHeight
                                            ));
                    }
                }
            }
        }


    }
}
