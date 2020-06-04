using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WavingMan
{
    public class Position
    {
        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public  int X { get; set; }
        public int Y { get; set; }

        public void Move(Position p)
        {
            X += p.X;
            Y += p.Y;
        }
    }
}
