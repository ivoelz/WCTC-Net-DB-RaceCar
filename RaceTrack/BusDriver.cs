using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class BusDriver : Driver
    {
        public BusDriver(RaceCar car) : base(car)
        {
            Name = "Bus Driver";
            SkillLevel = 2;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}