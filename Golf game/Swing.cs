using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_game
{
    class Swing
    {

        public Swing(int angle, int velocity, double dist)
        {
            Angle = angle;
            Velocity = velocity;
            Distance = dist;
        }
        public int Angle { get; set; }
        public int Velocity { get; set; }
        public double Distance { get; set; }
    }
}
