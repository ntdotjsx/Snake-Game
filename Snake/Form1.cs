namespace Snake
{
    public partial class Form1 : Form
    {
        private List<berry> Snake = new List<berry>();
        private berry food = new berry();
        public Form1()
        {
            InitializeComponent();

            new Settings();

            gameTimer.Interval = 1000 / Settings.Speed;

            //gameTimer.Tick += UpdateScreen; //FIX

            gameTimer.Start();

            StartGame();
        }

        private void StartGame()
        {
            new Settings();

            Snake.Clear();
            berry head = new berry { X = 10, Y = 5 };
            Snake.Add(head);

            CountS.Text = Settings.Score.ToString();
            GenerateFood();
        }

        private void GenerateFood()
        {
            int maxXPos = PBgame.Size.Width / Settings.Width;
            int maxYPos = PBgame.Size.Height / Settings.Height;

            Random random = new Random();
            food = new berry { X = random.Next(0, maxXPos), Y = random.Next(0, maxYPos) };
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            if (Settings.GameOver)
            {
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                {
                    Settings.direction = Direction.Right;
                }
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                {
                    Settings.direction = Direction.Left;
                }
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                {
                    Settings.direction = Direction.Up;
                }
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                {
                    Settings.direction = Direction.Down;
                }

                MovePlayer();
            }

            PBgame.Invalidate();
        }

        private void Die() 
        { 
            Settings.GameOver = true;
        }

        private void MovePlayer()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:
                            Snake[i].X++;
                            break;
                        case Direction.Left:
                            Snake[i].X--;
                            break;
                        case Direction.Up:
                            Snake[i].Y--;
                            break;
                        case Direction.Down:
                            Snake[i].Y++;
                            break;
                    }
                }

                int maxXPos = PBgame.Size.Width / Settings.Width;
                int maxYPos = PBgame.Size.Height / Settings.Height;

                if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].Y >= maxXPos)
                {
                    Die();
                }

                for (int j = 1; j < Snake.Count; j++)
                {
                    if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                    {
                        Die();
                    }
                }

            }
        }

        private void PBgame_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                for (int i = 0; i < Snake.Count; i++)
                {
                    Brush snakeColour;
                    if (i == 0)
                    {
                        snakeColour = Brushes.Brown;
                    }
                    else
                    {
                        snakeColour = Brushes.Gold;
                    }

                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));

                    canvas.FillEllipse(snakeColour,
                        new Rectangle(food.X * Settings.Width,
                            food.Y * Settings.Height, Settings.Width, Settings.Height
                        ));
                }
            }
            else
            {
                string gameOver = "Game Over";
                GameOverUI.Text = gameOver;
                GameOverUI.Visible = true;
            }
        }
    }
}