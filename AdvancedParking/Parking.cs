using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedParking
{
    internal class Parking
    {
        private string _parkingName;

        private string _parkingAddress; 

        private int _parkingCapacity;

        private int _carsOnParking;

        /// <summary>
        /// Constructor for Parking object
        /// </summary>
        /// <param name="parkingName"> </param> 
        /// <param name="parkingAddress"> </param> 
        /// <param name="parkingCapacity"> </param> 
        /// <param name="carsOnParking"> </param> 

        public Parking(string parkingName, string parkingAddress, int parkingCapacity)
        {
            _parkingName = parkingName;
            _parkingAddress = parkingAddress;
            _parkingCapacity = parkingCapacity;
            _carsOnParking = 0;

        }
        private List<Car> cars = new List<Car>();

        /// <summary>
        /// Adding a new car to the parking 
        /// </summary>
        /// <param name="newCar"> </param> 
        /// <returns> </returns> 

        public List<Car> AddNewCar(Car newCar)
        {
            if (_carsOnParking < _parkingCapacity)
            {
                _carsOnParking += 1;
                newCar.ArrivalTime = DateTime.Now;
                cars.Add(newCar);
                Console.WriteLine($"A new car with registration number {newCar.RegistrationNumber} " +
                    $"arrived to the parking at {newCar.ArrivalTime}");
                return cars;
            }
            else
            {
                Console.WriteLine("No parking places available");
                return cars;
            }
            /// <summary>
            /// Deleting car from the parking 
            /// </summary>
            /// <param name="carForRemove"> </param> 
            /// <returns> </returns> 
        }
        public List<Car> RemoveCar(Car carForRemove)
        {
            if (_carsOnParking > 0)
            {
                _carsOnParking -= 1;
                cars.RemoveAll(car => car.Id == carForRemove.Id);
                carForRemove.DepartureTime = DateTime.Now;
                Console.WriteLine($"The car with registration number {carForRemove.RegistrationNumber} " +
                    $"has left the parking. Departure time is {carForRemove.DepartureTime}");
                return cars;
            }
            else
            {
                Console.WriteLine("There are no cars to leave the parking");
                return cars;
            }
        }
        /// <summary>
        ///Getting all cars from parking list
        /// </summary>
       /// <returns> </returns> 
       public List<Car> GetAllCars()
        {
            return cars;
        }

        /// <summary>
        ///Reterns car parking status info
        /// </summary>
        /// <returns>Parking status info </returns>
        public void GetStateMessage()

        {
            Console.WriteLine($"Available parking spaces {_parkingCapacity - _carsOnParking} " +
                $" Occupied parking spaces {_carsOnParking}");
        }
        /// <summary>
        ///Reterns parking name and address
        /// </summary>
        /// <returns>Car parking general info </returns>
        public void GetParkingNameAddress()

        {
            Console.WriteLine("Parking general info:");
            Console.WriteLine($"Parking name:{_parkingName}");
            Console.WriteLine($"Parking address:{_parkingAddress}");
        }
    }
}
    