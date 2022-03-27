﻿// See https://aka.ms/new-console-template for more information
using InterfaceClass.Entities;
using InterfaceClass.Services;
using System.Globalization;

Console.WriteLine("Enter rental data");
Console.Write("Car model: ");
string model = Console.ReadLine();
Console.Write("Pickup (dd/MM/yyyy hh:ss): ");
DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
Console.Write("Return (dd/MM/yyyy hh:ss): ");
DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

Console.Write("Enter price per hour: ");
double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Enter price per day: ");
double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

CarRental carRental = new CarRental(start, finish, new Vehicle(model));

RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

rentalService.ProcessInvoice(carRental);

Console.WriteLine("INVOICE:");
Console.WriteLine(carRental.Invoice);