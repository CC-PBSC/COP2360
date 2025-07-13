public class MainClass
{
        Vehicle myVehicle = new Vehicle("Toyota", "Corolla", 2020);
        Truck myTruck = new Truck("Ford", "F-150", 2019, 30);
        Car myCar = new Car("Honda", "Civic", 2021, "Red");
}
    //created by CC-PBSC, Module 3 Discussion, 2360
    //creates class 
    public class Vehicle
    {
        //create variables
        public string Make;
        public string Model;
        public bool fourWheelDrive;
        public int vYear;

        //initializes the object
        public Vehicle() { }
        // initializes object that contains parameters
        public Vehicle(string make, string model, int vyear) { 
            Make = make;
            Model = model;
            vYear = vyear;
        
        }

    }

    public class Truck : Vehicle
    {
        //unique variable, in  squared feet
        public int bedSpace;
        
        //default initialization and one that takes methods
        public Truck() { }
        public Truck(string make, string model, int year, int bedSpace)
            : base(make, model, year)
        {
            BedSpace = bedSpace;
        }
    }

    public class Car: Vehicle
    {
        //unique variable
        string color;

        //default initialization and o ne that takes methods
        public Car() { }
        public Car(string make, string model, int year, string color)
            : base(make, model, year)
        {
            Color = color;
        }
    }

