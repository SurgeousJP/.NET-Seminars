using System;

VehicleFactory carFactory = new CarFactory();
IVehicle car = carFactory.CreateVehicle();
car.Drive();

// Bike Factory
VehicleFactory bikeFactory = new BikeFactory();
IVehicle bike = bikeFactory.CreateVehicle();
bike.Drive();
