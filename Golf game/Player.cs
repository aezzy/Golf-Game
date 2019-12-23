using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_game
{
    class Player
    {
        //Player
        public int Swing { get; set; }
        public string Name { get; set; }

        public decimal Cup { get; set; }
        public decimal ArcBall { get; set; }
        public decimal BallDistance { get; set; }
        //public float Location { get; set; }

        //constructor
        public Player()
        { 
        
        }

        //Calculate the ball distance
        public float GetBallDistance(float angle, float velocity)
        {
            float BallDistance = angle + velocity;
            angle = 45F;
            double angleRadians = (Math.PI / 180) * angle;
            velocity = 52;
            return BallDistance;
        }


        //Calculate progress
        public void GetResult()
        {

        }

        public void  StartGame(float angle, float velocity, float gravity)
        {

            angle = 45;
            velocity = 52;
            gravity = 9.8F;
            double angleInRadians = (Math.PI / 180) * angle;


            double distance = Math.Pow(velocity, 2) / gravity * Math.Sin(2 *
            angleInRadians);

            
           
           for(int swings=1; swings<5;swings++)
            {
                Console.WriteLine("the swing{0} and the distance{1}", swings, distance);
            }

            Console.WriteLine();

        }

    }
}
