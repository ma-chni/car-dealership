using System;
namespace CarDealerShip.Domain
{
    internal abstract class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string LicensePlate { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }


        protected Car(int id, string brand, string model, string color, string licensePlate, int price, int year)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Color = color;
            LicensePlate = licensePlate;
            Price = price;
            Year = year;
        }
    }
}
