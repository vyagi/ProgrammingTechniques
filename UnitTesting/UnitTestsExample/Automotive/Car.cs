using System;

namespace Automotive
{
    public class Car
    {
        private static int _carsCreated;

        private double _fuelLevel;
        private double _kilometersCounter;
        private double _tripKilometersCounter;
        public string Brand { get; }
        public int TankCapacity { get; }
        public int FuelConsumptionPer100Km { get; }
        public int CurrentFuelLevel => (int)_fuelLevel;
        public int KilometerCounter => (int)_kilometersCounter;
        public int TripKilometerCounter => (int)_tripKilometersCounter;

        public Car(string brand, int tankCapacity, int fuelConsumptionPer100Km)
        {
            _carsCreated++;

            Brand = brand;
            TankCapacity = tankCapacity;
            FuelConsumptionPer100Km = fuelConsumptionPer100Km;
        }

        public void Tank(int howMuch)
        {
            if (howMuch + _fuelLevel > TankCapacity)
                _fuelLevel = TankCapacity;
            else
                _fuelLevel += howMuch;
        }

        public void Drive(int kilometers)
        {
            var range = 100.0 * _fuelLevel / FuelConsumptionPer100Km;
            if (range < kilometers)
            {
                _tripKilometersCounter += range;
                _kilometersCounter += range;
                _fuelLevel = 0;
            }
            else
            {
                _tripKilometersCounter += kilometers;
                _kilometersCounter += kilometers;
                _fuelLevel -= 1.0 * kilometers * FuelConsumptionPer100Km / 100;
            }

            if (_tripKilometersCounter > 999) _kilometersCounter %= 1000;
        }

        public void ResetTripCounter() => _tripKilometersCounter = 0;

        public static int CarsCreated => _carsCreated;
    }
}
