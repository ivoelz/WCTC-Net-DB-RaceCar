﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Minivan : RaceCar
    {
        public Minivan()
        {
            Name = "Minivan";
            TopSpeed = 80;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine starts");
        }

        // VS code made me add these to implement inherited abstract member
        public override void StopEngine()
        {
            throw new NotImplementedException();
        }
    }
}
