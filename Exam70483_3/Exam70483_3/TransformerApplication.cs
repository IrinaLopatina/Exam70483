using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_3
{
    class TransformerApplication
    {
        public enum Landscape
        {
            Air,
            Road,
            Water
        }

        public interface ITransformer
        {
            int Wheels { get; }
            double MaxSpeed { get; }
            ITransformer Run(Landscape newLandscape);
        }

        public abstract class Transformer : ITransformer
        {
            public int Wheels { get; protected set; }
            public double MaxSpeed { get; protected set; }

            public abstract ITransformer Run(Landscape newLandscape);
        }

        public class Jet : Transformer
        {
            public Jet()
            {
                Wheels = 8;
                MaxSpeed = 900;
            }

            public override ITransformer Run(Landscape newLandscape)
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

        public class Car : Transformer
        {
            public Car()
            {
                Wheels = 4;
                MaxSpeed = 350;
            }
            public override ITransformer Run(Landscape newLandscape)
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

        public class Boat : Transformer
        {
            public Boat()
            {
                Wheels = 0;
                MaxSpeed = 200;
            }
            public override ITransformer Run(Landscape newLandscape)
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

        public void RunTransformerApplication()
        {
            ITransformer transformer = new Jet();
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", transformer.Wheels, transformer.MaxSpeed));

            transformer = transformer.Run(Landscape.Road);
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", transformer.Wheels, transformer.MaxSpeed));

            transformer = transformer.Run(Landscape.Road);
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", transformer.Wheels, transformer.MaxSpeed));

            transformer = transformer.Run(Landscape.Water);
            Console.WriteLine(String.Format("My values: wheels = {0}, max speed = {1}", transformer.Wheels, transformer.MaxSpeed));


        }
    }
}
