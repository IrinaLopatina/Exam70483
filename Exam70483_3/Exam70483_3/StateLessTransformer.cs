using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_3
{
    public class StateLessTransformer
    { 
        public enum Landscape
        {
            Air,
            Road,
            Water
        }

        public interface IVehicle
        {
            int Wheels { get; }
            double MaxSpeed { get; }
            IVehicle Run(Landscape newLandscape);
        }

        public abstract class Vehicle : IVehicle
        {
            public int Wheels { get; protected set; }
            public double MaxSpeed { get; protected set; }

            public abstract IVehicle Run(Landscape newLandscape);
        }

        public class Jet : Vehicle
        {
            public Jet()
            {
                Wheels = 8;
                MaxSpeed = 900;
            }

            public override IVehicle Run(Landscape newLandscape)
            {
                switch (newLandscape)
                {
                    case Landscape.Road:
                        return new Car();
                    case Landscape.Water:
                        return new Boat();
                    default:
                        return this;
                }
            }
        }

        public class Car : Vehicle
        {
            public Car()
            {
                Wheels = 4;
                MaxSpeed = 350;
            }
            public override IVehicle Run(Landscape newLandscape)
            {
                switch (newLandscape)
                {
                    case Landscape.Air:
                        return new Jet();
                    case Landscape.Water:
                        return new Boat();
                    default:
                        return this;
                }
            }
        }

        public class Boat : Vehicle
        {
            public Boat()
            {
                Wheels = 0;
                MaxSpeed = 200;
            }
            public override IVehicle Run(Landscape newLandscape)
            {
                switch (newLandscape)
                {
                    case Landscape.Road:
                        return new Car();
                    case Landscape.Air:
                        return new Jet();
                    default:
                        return this;
                }
            }
        }

        public void Run()
        {
            IVehicle vehicle = new Jet();
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", vehicle.Wheels, vehicle.MaxSpeed));

            vehicle = vehicle.Run(Landscape.Road);
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", vehicle.Wheels, vehicle.MaxSpeed));

            vehicle = vehicle.Run(Landscape.Road);
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", vehicle.Wheels, vehicle.MaxSpeed));

            vehicle = vehicle.Run(Landscape.Water);
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", vehicle.Wheels, vehicle.MaxSpeed));
        }
    }
}
