// See https://aka.ms/new-console-template for more information
using DependencyInjectionPattern.Concrete;


var userAddress = new UserAddress { City = "São Paulo", Country = "Brazil", ZipCode = "01001-001" };
var destinationAddress = new UserAddress { City = "Rio de Janeiro", Country = "Brazil", ZipCode = "22460-050" };
var distanceCalculator = new DistanceCalculator(userAddress, destinationAddress);
distanceCalculator.Calculate();

Console.ReadKey();
