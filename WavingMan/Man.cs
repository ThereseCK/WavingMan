using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace WavingMan
{
   public class Man
    {
        public Position Position { get; }
        public Position Speed { get; }
        protected bool _shouldWaveNextTime;

        public Man(int posX, int posY, int dirX, int dirY)
        {
            Position = new Position(posX, posY);
            Speed = new Position(dirX, dirY);
        }
        public void Show()
        {
            SetCursorTop();
            SetCursorLeft();
            Head();
            SetCursorLeft();
            Body();
            SetCursorLeft();
            Console.Write("/ \\");
            _shouldWaveNextTime = !_shouldWaveNextTime;
        }

        protected virtual void Body()
        {
            Console.WriteLine(_shouldWaveNextTime ? " |\\ " : " |");
        }

        protected virtual void Head()
        {
            Console.WriteLine(_shouldWaveNextTime ? "\\o " : " o");
        }

        private void SetCursorLeft()
        {
            Console.CursorLeft = Math.Max(Position.X - 1, 0);
        }

        private void SetCursorTop()
        {
            Console.CursorTop = Math.Max(Position.Y, 0);
        }

        public void Move()
        {
            var windowWidth = Console.WindowWidth;
            var windowHeight = Console.WindowHeight;

            if (Position.X <= 1) Speed.X = 1;
            if (Position.X >= windowWidth - 1) Speed.X = -1;
            if (Position.Y <= 1) Speed.Y = 1;
            if (Position.Y >= windowHeight - 1) Speed.Y = -1;

            Position.Move(Speed);
        }

     
    }
}
