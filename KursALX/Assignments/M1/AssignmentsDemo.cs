using KursALX.Assignments.M1.Classes;

namespace KursALX.Assignments.M1
{
    public class AssignmentsDemo
    {
        public static void Run()
        {
            var car = new Car("Red");
            var carcopy = new Car(car);
            var carBetter = new Car("Blue", "Alfa Romeo", "159 sportwagon", 4, true);
            var airplane = new Airplane();
            airplane.Color = "White";
            airplane.Name = "Cool Plane";
            airplane.Make = "Cessna";
            airplane.Model = "172C";
            airplane.ProductionYear = 1961;

            car.Present();
            car.Drive();
            carBetter.Present();
            carBetter.Drive();
            Console.WriteLine("kopia obiektu car");
            carcopy.Present();
            airplane.Welcome();
            Console.WriteLine(airplane.WhatIfOlder(4));
        }
    }
}
