using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class MainForm : Form
    {
        const int REFRESH_INTERVAL_MS = 500;

        private Timer mTimer;
        private Snake mSnake;
        private Point mFood;

        private DIRECTION mDirectionUser;

        public MainForm()
        {
            InitializeComponent();

            /* Disable exit game */
            this.exitToolStripMenuItem.Enabled = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /* Initialize timer */
            this.mTimer = new Timer();
            this.mTimer.Interval = REFRESH_INTERVAL_MS;
            this.mTimer.Tick += new EventHandler(MainForm_Update);

            /* Initialize user direction */
            this.mDirectionUser = DIRECTION.NONE;

            this.mainFormStatusLabel.Text = "Please start !";
        }

        private void MainForm_Exit(object sender, EventArgs e)
        {
            this.mTimer.Stop();

            /* Enable new game */
            this.newToolStripMenuItem.Enabled = true;

            /* Disable exit game */
            this.exitToolStripMenuItem.Enabled = false;

            this.mainFormStatusLabel.Text = "Please start !";
        }

        private void MainForm_NewGame(object sender, EventArgs e)
        {
            this.mSnake = new Snake();
            this.generateFood();

            /* Refresh the canvas */
            this.mainFormMap.Invalidate();

            /* Set the focus to catch the key events */
            this.mainFormMap.Focus();

            /* Disable new game */
            this.newToolStripMenuItem.Enabled = false;

            /* Enable exit game */
            this.exitToolStripMenuItem.Enabled = true;

            this.mainFormStatusLabel.Text = "";

            /* Start the timer */
            this.mTimer.Start();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (this.mSnake != null &&
                this.mFood != null)
            {
                Graphics canvas = e.Graphics;

                canvas.FillRectangle(Brushes.Orange,
                    new Rectangle(this.mFood.getX() * Point.WIDTH, this.mFood.getY() * Point.HEIGHT, Point.WIDTH, Point.HEIGHT));

                for (int i = 0; i < this.mSnake.getLength(); i++)
                {
                    Brush snake_color = (i == 0 ? Brushes.DarkGreen : Brushes.Green);
                    canvas.FillRectangle(snake_color,
                        new Rectangle(this.mSnake.getPartX(i) * Point.WIDTH,
                                        this.mSnake.getPartY(i) * Point.HEIGHT, Point.WIDTH, Point.HEIGHT));
                }
            }
        }

        private void MainForm_Update(object sender, EventArgs e)
        {
            switch (this.mDirectionUser)
            {
                case DIRECTION.DOWN:
                    if (this.mSnake.isBaby() || this.mSnake.getPartY(0) == this.mSnake.getPartY(1))
                        this.mSnake.setDirection(DIRECTION.DOWN);
                    break;

                case DIRECTION.RIGHT:
                    if (this.mSnake.isBaby() || this.mSnake.getPartX(0) == this.mSnake.getPartX(1))
                        this.mSnake.setDirection(DIRECTION.RIGHT);
                    break;

                case DIRECTION.LEFT:
                    if (this.mSnake.isBaby() || this.mSnake.getPartX(0) == this.mSnake.getPartX(1))
                        this.mSnake.setDirection(DIRECTION.LEFT);
                    break;

                case DIRECTION.UP:
                    if (this.mSnake.isBaby() || this.mSnake.getPartY(0) == this.mSnake.getPartY(1))
                        this.mSnake.setDirection(DIRECTION.UP);
                    break;

                case DIRECTION.NONE:
                default:
                    break;
            }

            if (this.mSnake.getPartX(0) == this.mFood.getX() &&
                this.mSnake.getPartY(0) == this.mFood.getY())
            {
                this.mSnake.Update(true);
                this.generateFood();
            }
            else
            {
                this.mSnake.Update(false);
            }

            if (this.mSnake.getPartX(0) < 0 ||
                this.mSnake.getPartX(0) >= this.mainFormMap.Width / Point.WIDTH ||
                this.mSnake.getPartY(0) < 0 ||
                this.mSnake.getPartY(0) >= this.mainFormMap.Height / Point.HEIGHT ||
                this.mSnake.isBitting())
            {
                this.mTimer.Stop();

                this.mainFormStatusLabel.Text = "Game Over !";

                /* Enable new game */
                this.newToolStripMenuItem.Enabled = true;

                /* Disable exit game */
                this.exitToolStripMenuItem.Enabled = false;
            }
            else
            {
                /* Refresh the canvas */
                this.mainFormMap.Invalidate();
            }
        }

        private void generateFood()
        {
            Random random = new Random();
            Boolean isSnakePosition = false;
            int foodX;
            int foodY;

            do
            {
                isSnakePosition = false;
                foodX = random.Next(0, this.mainFormMap.Width / Point.WIDTH);
                foodY = random.Next(0, this.mainFormMap.Height / Point.HEIGHT);

                for(int i=0; i < this.mSnake.getLength(); i++)
                {
                    if(this.mSnake.getPartX(i).Equals(foodX) &&
                        this.mSnake.getPartY(i).Equals(foodY))
                    {
                        isSnakePosition = true;
                    }
                }
            }
            while (isSnakePosition);

            this.mFood = new Point(foodX, foodY);
        }

        private void MainForm_KeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                    this.mDirectionUser = DIRECTION.DOWN;
                    break;

                case Keys.Left:
                    this.mDirectionUser = DIRECTION.LEFT;
                    break;

                case Keys.Right:
                    this.mDirectionUser = DIRECTION.RIGHT;
                    break;

                case Keys.Up:
                    this.mDirectionUser = DIRECTION.UP;
                    break;

                default:
                    this.mDirectionUser = DIRECTION.NONE;
                    break;
            }
        }

        private void MainForm_Dispose(object sender, EventArgs e)
        {
            this.mTimer.Stop();

            this.Dispose();
        }
    }
}
