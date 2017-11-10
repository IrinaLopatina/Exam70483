using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_3
{
    public interface IState
    {
        void ApplyAirLandscape();
        void ApplyRoadLandscape();
        void ApplyWaterLandscape();
    }

    public enum Landscape
    {
        Air,
        Road,
        Water
    }

    public abstract class Vehicle
    {
        public int Wheels { get; protected set; }
        public double MaxSpeed { get; protected set; }
        public string Name { get; protected set; }
        public StateFullTransformer transformer;
    }


    public class StateFullTransformer
    { 
        IState carState;
        IState jetState;
        IState boatState;

        IState state;

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetCarState()
        {
            return carState;
        }

        public IState GetJetState()
        {
            return jetState;
        }

        public IState GetBoatState()
        {
            return boatState;
        }

        public StateFullTransformer()
        {
            carState = new Car(this);
            jetState = new Jet(this);
            boatState = new Boat(this);

            state = carState;
        }

        void ApplyAirLandscape()
        {
            state.ApplyAirLandscape();
        }

        void ApplyRoadLandscape()
        {
            state.ApplyRoadLandscape();
        }

        void ApplyWaterLandscape()
        {
            state.ApplyWaterLandscape();
        }
            
        public void Run()
        {
            Console.WriteLine("***********************************************************************************");
            state.ApplyAirLandscape();
            Console.WriteLine("***********************************************************************************");
            state.ApplyAirLandscape();
            Console.WriteLine("***********************************************************************************");
            state.ApplyRoadLandscape();
            Console.WriteLine("***********************************************************************************");
            state.ApplyWaterLandscape();
            Console.WriteLine("***********************************************************************************");
            state.ApplyAirLandscape();
        }

}

    public class Jet : Vehicle, IState
    {
        public Jet(StateFullTransformer transformer)
        {
            Wheels = 8;
            MaxSpeed = 900;
            Name = "Jet";
            this.transformer = transformer;
        }
        public void ApplyAirLandscape()
        {
            Console.WriteLine("State {0} is not changed!", Name);
        }
        public void ApplyRoadLandscape()
        {
            Console.WriteLine(String.Format("Changed values: name = {0}, wheels = {1}, max speed = {2}", Name, Wheels, MaxSpeed));
            transformer.SetState(transformer.GetCarState());
        }
        public void ApplyWaterLandscape()
        {
            Console.WriteLine(String.Format("Changed values: name = {0}, wheels = {1}, max speed = {2}", Name, Wheels, MaxSpeed));
            transformer.SetState(transformer.GetBoatState());
        }
    }

    public class Car : Vehicle, IState
    {
        public Car(StateFullTransformer transformer)
        {
            Wheels = 4;
            MaxSpeed = 350;
            Name = "Car";
            this.transformer = transformer;
        }
        public void ApplyAirLandscape()
        {
            Console.WriteLine(String.Format("Changed values: name = {0}, wheels = {1}, max speed = {2}", Name, Wheels, MaxSpeed));
            transformer.SetState(transformer.GetJetState());
        }
        public void ApplyRoadLandscape()
        { 
            Console.WriteLine("State {0} is not changed!", Name);
        }
        public void ApplyWaterLandscape()
        {
            Console.WriteLine(String.Format("Changed values: name = {0}, wheels = {1}, max speed = {2}", Name, Wheels, MaxSpeed));
            transformer.SetState(transformer.GetBoatState());
        }
    }

    public class Boat : Vehicle, IState
    {
        public Boat(StateFullTransformer transformer)
        {
            Wheels = 0;
            MaxSpeed = 200;
            Name = "Boat";
            this.transformer = transformer;
        }
        public void ApplyAirLandscape()
        {
            Console.WriteLine(String.Format("Changed values: name = {0}, wheels = {1}, max speed = {2}", Name, Wheels, MaxSpeed));
            transformer.SetState(transformer.GetJetState());
        }
        public void ApplyRoadLandscape()
        {
            Console.WriteLine(String.Format("Changed values: name = {0}, wheels = {1}, max speed = {2}", Name, Wheels, MaxSpeed));
            transformer.SetState(transformer.GetCarState());
        }
        public void ApplyWaterLandscape()
        {
            Console.WriteLine("State {0} is not changed!", Name);
        }
    }
}
