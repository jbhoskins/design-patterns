using System;

namespace FactoryDesignPattern {
    // Run
    class MainClass {
        public static void Main(string[] args) {
            VehicleFactory vf = new VehicleFactory();
            Vehicle vehicle = vf.GetVehicle("car", "red");

            Console.WriteLine(vehicle.Color + " " + vehicle.GetType());
        }
    }

    // Objects defined for factory
    public abstract class Vehicle {
        //public int numberOfWheels { get; set; }
        //public string color { get; set; }

        private int numberOfWheels;
        public int NumberOfWheels { 
            get { return numberOfWheels; } 
            set { numberOfWheels = value; } 
        }

        private string color;
        public string Color {
            get { return color; }
            set { color = value; }
        }
    }

    class Car : Vehicle {
        public Car(string color) {
            this.Color = color;
            NumberOfWheels = 4;
        }
    }

    class Bicycle : Vehicle {
        public Bicycle(string color) {
            this.Color = color;
            NumberOfWheels = 2;
        }
    }

    // Actual factory
    class VehicleFactory {

        public VehicleFactory() {
            // Nothing to do
        }
        
        public Vehicle GetVehicle(string type, string color) {
            if (type.Contains("bicycle")) {
                return new Bicycle(color);
            } else if (type.Contains("car")) {
                return new Car(color);
            } else {
                throw new ArgumentException("Vehicle type does not exist.");
            }
        }
    }
}
