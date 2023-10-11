namespace AdvancedParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color color1 = new Color(20, 20, 20, 20);
            Color color2 = new Color(30, 70, 00, 85);

            Car car1 = new Car(1, "Focus Titanium", "Ford", color1, "AI2012HB");
            Car car2 = new Car(2, "TT", "Audi", color2, "AH3333BK");
            Car car3 = new Car(3, "RAV-4", "Toyota", color1, "AX5033VT");

            Parking parking1 = new Parking("Giant 4", "Liberty Square 1", 2);

            parking1.GetParkingNameAddress();
            parking1.GetStateMessage();

            parking1.AddNewCar(car1);
            parking1.AddNewCar(car2);
            parking1.AddNewCar(car3);

            parking1.RemoveCar(car2);

            parking1.AddNewCar(car3);

            parking1.GetStateMessage();
            
           List<Car> carlist =  parking1.GetAllCars();

           Console.WriteLine("All cars currently located on the parking:");

           foreach (Car car in carlist) 
            
            { 
                Console.WriteLine($"{car.RegistrationNumber} {car.ArrivalTime}"); 
            }

            car1.ChangeColor(color2);


        }
    }
}