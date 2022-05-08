using System;
using System.Collections.Generic;
using System.Text;

namespace Bolt
{
    class Car:IVehicle
    {
        public Car(string brand, string model, int capacity, double baggage,string driver)
        {
            Id = _id++;
            Brand = brand;
            Model = model;
            Capacity = capacity;
            Baggage = baggage;
            Driver = driver;
        }
        private static int _id = 2000;
        public int Id { get; }
        private string _brand;
        private string _model;
        private int _capacity;
        private string _driverFullname;
        private double _baggage;
        public string Brand
        {
            get => _brand;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 3)
                    _brand = value;
            }
        }
        public string Model
        {
            get => _model;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 3)
                    _model = value;
            }
        }
        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value > 0 && value < 200)
                    _capacity = value;
            }
        }
        public double Baggage
        {
            get => _baggage;
            set
            {
                if (value > 0 && value < 1000)
                    _baggage = value;
            }
        }
        public string Driver
        {
            get => _driverFullname;
            set
            {
                if (value.Length > 4)
                    _driverFullname = value;
            }
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand} - Model: {Model} - Capacity: {Capacity} - Baggage: {Baggage}\nDriver: {Driver}\n";
        }
        public string InfoForAdmin()
        {
            return $"Id: {Id} - Brand: {Brand} - Model: {Model} - Capacity: {Capacity} - Baggage: {Baggage}\nDriver: {Driver}\n";

        }
    }
}
