﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TheTankGame.Entities.Miscellaneous;
using TheTankGame.Entities.Miscellaneous.Contracts;
using TheTankGame.Entities.Vehicles.Contracts;
using TheTankGame.Entities.Vehicles.Factories.Contracts;

namespace TheTankGame.Entities.Vehicles.Factories
{
    public class VehicleFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(string vehicleType, string model, double weight, decimal price, int attack, int defense, int hitPoints)
        {
            var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == vehicleType);
            var vehicleInstance = (IVehicle)Activator.CreateInstance(type, new object[] { model, weight, price, attack, defense, hitPoints, new VehicleAssembler()});
            return vehicleInstance;
        }
    }
}
