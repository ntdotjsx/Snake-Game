using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    public class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Speed { get; set; }  
        public static int Score { get; set; }
        public static int Point { get; set; }
        public static bool GameOver { get; set; }
        public static Direction direction { get; set; }

        public Settings()
        {
            Width = 16; 
            Height = 16; 
            Speed = 0; 
            Score = 1000; 
            Point = 0;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
