using System;
using System.Collections.Generic;
using System.Text;

namespace Happy_Gilmore
{
    public class Shooter
    {
        public Shooter()
        {
            Win = 0;
            Loss = 0;
        }

        public int Win { get; set; }
        public int Loss { get; set; }
        public int GameNumber { get; set; }

        public int WinTotal()
        {
            return Win;
        }

        public int LossTotal()
        {
            return Loss;
        }
        
        public void WinHole()
        {
            Win +=1;
        }

        public void LossHole()
        {
            Loss++;
        }

        public void SetNumber()
        {
            Random number = new Random();
            int randoNumber = number.Next(1, 2);
            GameNumber = randoNumber;
        }
    }
}
