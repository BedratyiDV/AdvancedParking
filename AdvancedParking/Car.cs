﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdvancedParking
{
    
        internal class Car
    {
        private int _id;

        private Color _color;
        public string Model { get; set; }
        public string Brand { get; set; }

        public string RegistrationNumber { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }

        public int Id { get => _id; }

        /// <summary>
        /// Constructor for Car object
        /// </summary>
        /// <param name="id"> </param> 
        /// <param name="model"> </param> 
        /// <param name="brand"> </param> 
        /// <param name="color"> </param> 
        /// <param name="registrationNumber"> </param> 
        public Car(int id, string model, string brand, Color color,  string registrationNumber) 
        {
            _id = id;
            Model = model;
            Brand = brand;
            _color = color;
            RegistrationNumber = registrationNumber; 
        }
        /// <summary>
        /// Method for changing car color
        /// </summary>
        ///  <param name="color"> </param> 
        public void ChangeColor(Color color) 
        
        {
            Console.WriteLine($"Current color of car " +
                $"{this.RegistrationNumber} : {_color.Red},{_color.Green},{_color.Blue},{_color.Opacity}");

            _color = color;

            Console.WriteLine($"New color of car " +
                $"{this.RegistrationNumber}: {_color.Red},{_color.Green},{_color.Blue},{_color.Opacity}");

        }
    }
}
