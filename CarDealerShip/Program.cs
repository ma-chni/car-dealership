using System;
using System.Collections.Generic;
using static System.Console;
using CarDealerShip.Domain;
using System.Threading;


namespace CarDealerShip
{
    class MainClass
    {
        static readonly List<Car> carList = new List<Car>();
        static List<Customer> customerList = new List<Customer>();
        static List<Staff> staffList = new List<Staff>();

        public static void Main()
        {
            JohnDoe johnDoe = new JohnDoe(firstName: "John", lastName: "Doe", socialSecurityNumber: "1234", email: "JohnDoe@nomail.com", phoneNumber: "0745781254", salary: 600000); 
            customerList.Add(johnDoe);

            Tesla teslaX = new Tesla(id: 0, brand: "Tesla", model: "X", color: "Red", licensePlate: "1234", price: 500000, year:2015); 
            carList.Add(teslaX);

            Tesla teslaRoadster = new Tesla(id: 1, brand: "Tesla", model: "Roadster", color: "Red", licensePlate: "1234", price: 1000000, year: 2020); 
            carList.Add(teslaRoadster);

            Volvo volvoV40 = new Volvo(id: 2, brand: "Volvo", model: "V40", color: "Black", licensePlate: "4321", price: 600000, year: 2019); 
            carList.Add(volvoV40);

            Ceo ceo = new Ceo(firstName: "Ceo", lastName: "Ceo", socialSecurityNumber: "19801205-1234", email: "ceo@ceo.com", phoneNumber: "072132132", salary: 300000, position: "CEO"); 
            staffList.Add(ceo);

            bool shouldRun = true;
            while (shouldRun)
            {
                Clear();
                WriteLine("1. List staffs");
                WriteLine("2. List customers");
                WriteLine("3. List cars");
                WriteLine("4. Buy car");
                WriteLine("5. Exit");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();
                switch (keyPressed.Key)
                {

                    case ConsoleKey.D1:
                        foreach (var staff in staffList)
                        {if (staff == null) continue;
                            WriteLine("Position ｜ Firstname ｜ Lastname ｜ SocialSecurityNumber");
                            WriteLine("---------------------------------------------------------");
                            WriteLine($"{staff.Position}         {staff.FirstName}         {staff.LastName}         {staff.SocialSecurityNumber}");
                            ReadKey();

                           
                        }
                        break;
                    case ConsoleKey.D2:
                        foreach (var customer in customerList)
                        { if (customer == null) continue;
                            WriteLine("Firstname ｜ Lastname ｜ SocialSecurityNumber");
                            WriteLine("---------------------------------------------");
                            WriteLine($"{customer.FirstName}         {customer.LastName}         {customer.SocialSecurityNumber}");
                            ReadKey();
                            
                        }
                        break;
                    case ConsoleKey.D3:
                        foreach (var car in carList)
                        { if (car == null) continue;
                            WriteLine("Year ｜ Brand ｜ Model ｜ License Plate ｜ Price");
                            WriteLine("-------------------------------------------------");
                            WriteLine($"{car.Year}    {car.Brand}    {car.Model}        {car.LicensePlate}            {car.Price}");
                            ReadKey();
                            
                            
                        }
                        break;
                    case ConsoleKey.D4:
                        WriteLine("Please enter your Social Security Number:");
                        SetCursorPosition(41,0);
                        string socialSecurityNumber = ReadLine();

                        foreach (var cust in customerList)
                        {
                            foreach (var staff in staffList)
                            {
                            if (cust.SocialSecurityNumber == socialSecurityNumber)
                            {
                                    Clear();
                                    WriteLine($"Hello {cust.FirstName} {cust.LastName}");
                                    WriteLine($"Im {staff.FirstName} {staff.LastName} and I'm here to help you with your purchase!");
                                    WriteLine();
                                    WriteLine("Please enter the license plate number:");
                                    SetCursorPosition(38, 3);
                                    string licensePlate = ReadLine();
                                    foreach (var cars in carList)
                                    { if(cars == null) continue;
                                        if (cars.LicensePlate == licensePlate)
                                        {
                                            Clear();
                                            WriteLine($"Congrats you just bought a {cars.Brand} {cars.Model}");
                                            carList.RemoveAt(0);
                                            Thread.Sleep(2000);
                                            break;
                                        }
                                        else
                                        {
                                            Clear();
                                            WriteLine("No vehicle got that license plate number");
                                            Thread.Sleep(2000);
                                            break;
                                        }
                                    }
                            }
                            else
                            {
                                Clear();
                                WriteLine("Wrong Social Security Number / Customer dosen't exist");
                                Thread.Sleep(2000);
                                break;
                            }
                            }
                        }
                        break;
                    case ConsoleKey.D5:
                        shouldRun = false;
                        break;
                }
            }
        }
    }
}
