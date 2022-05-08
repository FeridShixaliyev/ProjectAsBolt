using System;
using System.Collections.Generic;
using System.Text;

namespace Bolt
{
    class Garage
    {
        public Garage(string name)
        {
            Id = _id++;
            Name = name;
        }
        private static int _id;
        public int Id { get; }
        public string Name { get; set; }

        private List<Bus> buses = new List<Bus>();
        private List<Minivan> minivans = new List<Minivan>();
        private List<Car> cars = new List<Car>();

        public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }

        public void AddVan(Minivan minivan)
        {
            minivans.Add(minivan);
        }

        public void AddCar(Car car)
        {
            cars.Add(car);
        }

        public void AGetAllVehicle()
        {
            Console.WriteLine("Aftobuslar:");
            foreach (var item in buses)
            {
                Console.WriteLine(item.InfoForAdmin());
            }
            Console.WriteLine("\nMinivanlar:");
            foreach (var item in minivans)
            {
                Console.WriteLine(item.InfoForAdmin());
            }
            Console.WriteLine("\nMinik aftomobilleri:");
            foreach (var item in cars)
            {
                Console.WriteLine(item.InfoForAdmin());
            }
        }

        public void GetBus()
        {
            foreach (var item in buses)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }

        public void GetVan()
        {
            foreach (var item in minivans)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }

        public void GetCar()
        {
            foreach (var item in cars)
            {
                Console.WriteLine(item.ShowInfo());
            }
        }
        public void RemoveCarById(int id)
        {
            if (cars.Exists(c => c.Id == id))
            {
                cars.RemoveAll(c => c.Id == id);
            }
            else
                Console.WriteLine("\nBele id-ye sahib minik aftomobili yoxdur!!!\n");
        }
        public void RemoveBusById(int id)
        {
            if (buses.Exists(b => b.Id == id))
            {
                buses.RemoveAll(b => b.Id == id);
            }
            else
                Console.WriteLine("Bele id-ye sahib minik aftomobili yoxdur!!!");
        }
        public void RemoveVanById(int id)
        {
            if (minivans.Exists(m => m.Id == id))
            {
                minivans.RemoveAll(m => m.Id == id);
            }
            else
                Console.WriteLine("Bele id-ye sahib minik aftomobili yoxdur!!!");
        }
        //---------------Car edit metodlari----------
        public void EditCarBrand(int id,string brand)
        {
            if (cars.Exists(c => c.Id == id))
            {
                cars.Find(c => c.Id == id).Brand = brand;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        public void EditCarModel(int id, string model)
        {
            if (cars.Exists(c => c.Id == id))
            {
                cars.Find(c => c.Id == id).Model = model;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        public void EditCarDriver(int id, string driver)
        {
            if (cars.Exists(c => c.Id == id))
            {
                cars.Find(c => c.Id == id).Driver = driver;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        //---------------Bus edit metodlari----------
        public void EditBusBrand(int id, string brand)
        {
            if (buses.Exists(c => c.Id == id))
            {
                buses.Find(c => c.Id == id).Brand = brand;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        public void EditBusModel(int id, string model)
        {
            if (buses.Exists(c => c.Id == id))
            {
                buses.Find(c => c.Id == id).Model = model;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        public void EditBusDriver(int id, string driver)
        {
            if (buses.Exists(c => c.Id == id))
            {
                buses.Find(c => c.Id == id).Driver = driver;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        //---------------Minivan edit metodlari----------
        public void EditVanBrand(int id, string brand)
        {
            if (minivans.Exists(c => c.Id == id))
            {
                minivans.Find(c => c.Id == id).Brand = brand;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        public void EditVanModel(int id, string model)
        {
            if (minivans.Exists(c => c.Id == id))
            {
                minivans.Find(c => c.Id == id).Model = model;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        public void EditVanDriver(int id, string driver)
        {
            if (minivans.Exists(c => c.Id == id))
            {
                minivans.Find(c => c.Id == id).Driver = driver;
            }
            else
                Console.WriteLine("\nId-ni duzgun daxil edin!!!\n");
        }
        //Filter metolari

        public List<Bus> FilterByBus(int min,int max,int baggage)
        {
            return buses.FindAll(x => x.Capacity >= min && x.Capacity <= max&&x.Baggage>=baggage);
        }
        public Bus FilterByBus(string brand)
        {
            return buses.Find(x => x.Brand == brand);
        }
        public List<Minivan> FilterByMinivan(int min, int max, int baggage)
        {
            return minivans.FindAll(x => x.Capacity >= min && x.Capacity <= max && x.Baggage >= baggage);
        }
        public Minivan FilterByMinivan(string brand)
        {
            return minivans.Find(x => x.Brand == brand);
        }
        public List<Car> FilterByCar(int min, int max, int baggage)
        {
            return cars.FindAll(x => x.Capacity >= min && x.Capacity <= max && x.Baggage >= baggage);
        } 
        public Car FilterByCar(string brand)
        {
            return cars.Find(x => x.Brand == brand);
        }
        //Privsate Listlerin erisebilirliy metodlari
        public List<Car> TakeCars()
        {
            return cars;
        }
        public List<Bus> TakeBus()
        {
            return buses;
        }
        public List<Minivan> TakeVans()
        {
            return minivans;
        }
    }
}
