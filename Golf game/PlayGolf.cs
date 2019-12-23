using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_game
{
    class PlayGolf
    {

        private int _AllowedNoOfSwings = 10;
        public float Gravity { get; set; }
        public double TotalDistanceTravelled { get; set; }
        public int DistanceToCup { get; set; }

        public List<Swing> Swings { get; set; }
        public int NoOfSwings { get; set; }

        private float _gravity = 9.8F;
        private int _angle;
        private int _velocity;
        public int Velocity
        {
            get { return _velocity; }
            set
            {
                if (value > 56)
                {
                    _velocity = 56;
                }
                else
                {
                    _velocity = value;
                }
            }
        }

        public double StopCondition { get; set; }

        public int Angle { get { return _angle; } set { _angle = value; } }
        public PlayGolf()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            DistanceToCup = rnd.Next(600, 801);
            NoOfSwings = 0;
            Swings = new List<Swing>();
        }

        public void SendStartInfoToUser()
        {
            Console.WriteLine("Welcome to our golf game");
            Console.WriteLine("The length of the  course is {0} meters", DistanceToCup);
            Console.WriteLine("You have {0} swings to get the ball close enough (less than 1 meter from cup)", _AllowedNoOfSwings);
        }

        public void AskUserForValues()
        {
            Console.Write("What angle? : ");
            Angle = int.Parse(Console.ReadLine());
            Console.Write("What velocity? : ");
            Velocity = int.Parse(Console.ReadLine());
        }
        public void SimulateSwing()
        {
            double distance = 0;
            double angleInRadians = (Math.PI / 180) * Angle;


            distance = Convert.ToDouble(Math.Pow(Velocity, 2) / _gravity * Math.Sin(2 * angleInRadians));
            Swing swing = new Swing(Angle, Velocity, distance);
            Swings.Add(swing);
            TotalDistanceTravelled = TotalDistanceTravelled + distance;
            StopCondition = DistanceToCup - TotalDistanceTravelled;
            NoOfSwings++;
            SendSwingInfoToUser(distance);

        }

        public void SendSwingInfoToUser(double dist)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Your last swing measured {0:0.00} meters", dist);
            Console.WriteLine("You have {0:0.00} meters to cup", StopCondition);
            Console.WriteLine("You have {0} swings left", _AllowedNoOfSwings - NoOfSwings);
        }

        public void DisplayEndingStausToUser()
        {
            foreach (var swing in Swings)
            {
                Console.WriteLine("Swing {0}", Swings.IndexOf(swing) + 1);
                Console.WriteLine("Distance travelled: {0:0.00}", swing.Distance);
                Console.WriteLine("Angle: {0}", swing.Angle);
                Console.WriteLine("Velocity: {0}", swing.Velocity);
            }
        }
    }
}










