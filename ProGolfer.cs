using System;
using System.Collections.Generic;
using System.Text;

namespace Happy_Gilmore
{
    public class ProGolfer
    {
        public ProGolfer()
        {
            Toughness = 70;
            Happyness = 40;
            Accuracy = 50;
            Distance = 300;
            Energy = 70;
            Name = "Gary Potter";
        }


        public string Name { get; set; }
        public int Toughness { get; set; }
        public int Happyness { get; set; }
        public int Accuracy { get; set; }
        public int Distance { get; set; }
        public int Energy { get; set; }

        public void SetName(string name)
        {
            Name = name;
        }

        public int GetToughness()
        {
            return Toughness;
        }
        
        public int GetHappyness()
        {
            return Happyness;
        }

        public int GetAccuracy()
        {
            return Accuracy;
        }

        public int GetDistance()
        {
            return Distance;
        }

        public int GetEnergy()
        {
            return Energy;
        }

        public void AllInTheHips()
        {
            Accuracy += 15;
            Energy -= 5;
            Happyness += 5;
            Toughness -= 10;
        }

        public void BattingCages()
        {
            if (GetEnergy() > 20)
            {
                Energy -= 20;
                Toughness += 20;
                Accuracy -= 1;
                Distance -= 1;
            }
            else
            {
                Energy = 0;
                Toughness += 20;
                Accuracy -= 1;
                Distance -= 1;
            }
        }

        public void DrivingRange()
        {
            if (GetEnergy() > 10)
            {
                Distance += 25;
                Energy -= 10;
                Happyness += 5;
                Toughness -= 5;
            }
            else
            {
                Distance += 25;
                Energy = 0;
                Happyness += 5;
                Toughness -= 5;
            }
        }

        public void HappyPlace()
        {
            if (GetEnergy() > 5)
            {
                Happyness += 55;
                Energy -= 5;
                Toughness -= 15;
            }
            else
            {
                Happyness += 55;
                Energy = 0;
                Toughness -= 15;
            }
        }

        public void PriceIsWrong()
        {
            if (GetEnergy() > 5)
            {
                Energy -= 5;
                Happyness -= 5;
                Toughness += 10;
                Distance -= 1;
                Accuracy -= 1;
            }
            else
            {
                Energy = 0;
                Happyness -= 5;
                Toughness += 10;
                Distance -= 1;
                Accuracy -= 1;
            }
        }

        public void ColdCut()
        {
            if (GetEnergy() < 50)
            {
                Energy += 50;
                Distance -= 1;
                Accuracy -= 1;
                Happyness += 5;
            }
            else
            {
                Energy = 100;
                Distance -= 1;
                Accuracy -= 1;
                Happyness += 5;
            }
        }

        public void Shooter()
        {
            if (GetEnergy() > 15)
            {
                Energy -= 15;
                Distance += 10;
                Accuracy += 10;
                Happyness -= 25;
            }
            else
            {
                Energy = 0;
                Distance += 10;
                Accuracy += 10;
                Happyness -= 25;
            }
        }
    }
}
