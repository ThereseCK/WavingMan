﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WavingMan
{
    class LeftHandedMan : Man
    {
        public LeftHandedMan(int posX, int posY, int dirX, int dirY) : base(posX, posY, dirX, dirY)
        {
        }

        protected override void Head()
        {
            Console.WriteLine(_shouldWaveNextTime ? " o/ " : " o");
        }
        protected override void Body()
        {
            Console.WriteLine(_shouldWaveNextTime ? "/| " : " |");
        }
        
    }
}
