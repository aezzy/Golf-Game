using System;
using System.Collections.Generic;
using System.Text;

namespace Golf_game
{
    class Golf
    {
        public double Angle { get; set; }
        public double Velocity { get; set; }
        public float Gravity { get; set; }
        public int Distance { get; set; }
        public int cup { get; set; }

        public Golf()
        { }

        public void PlayG(double angle, double velocity, float gravity)
        {
            gravity = 9.8F;
            Angle = angle;

            Velocity = velocity;

            double angleInRadians = (Math.PI / 180) * angle;


            Distance = Convert.ToInt32(Math.Pow(velocity, 2) / gravity * Math.Sin(2 *
             angleInRadians));


            cup = 320;

            int swings = 1;
            
                    if(Distance>800)
            { 
                        Console.WriteLine("you have lost", Distance);
            }

            if (Distance > cup || Distance < cup)
                    {
                        Console.WriteLine("you have made progress", Distance);
                    }
                   
                    if(Distance==cup)
                    {
                        Console.WriteLine("you have won");
                        //isAlive = false;
                        Console.WriteLine(Distance);
                    }
                   
                    
            }
        }

    }

