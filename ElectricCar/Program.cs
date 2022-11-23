using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricCar
{
    class Program
    {
        static void Main(string[] args)
        { }
    }
    class Car
    {
        public virtual void Move()
        {
            Console.WriteLine("Car is moving!");
        }

    }
    class ElectricCar : Car
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("Electric Car is Environment Friendly");
        }
        public void Charge()
        {
            Console.WriteLine("Car is charged!");
        }
    }

}
