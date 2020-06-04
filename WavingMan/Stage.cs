using System;
using System.Collections.Generic;
using System.Text;

namespace WavingMan
{
   public class Stage
   {
       private readonly Man[] _men = new Man[]
       {
           new Man(11, 5, -1, 0),
           new Man(7, 5, 1, 0),
           new LeftHandedMan(4, 5, 0, 0),
       };

        public void ShowAndMove()
        {
            Console.Clear();
            foreach (var person in _men)
            {
                person.Show();
                person.Move();
            }
        }
    }
}
