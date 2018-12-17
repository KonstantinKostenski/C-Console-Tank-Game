﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using TheTankGame.Entities.Parts.Contracts;
using TheTankGame.Entities.Parts.Factories.Contracts;

namespace TheTankGame.Entities.Parts.Factories
{
    public class PartFactory : IPartFactory
    {
        public IPart CreatePart(string partType, string model, double weight, decimal price, int additionalParameter)
        {
            partType = partType + "Part";
            var type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == partType);
            var partInstance = (IPart)Activator.CreateInstance(type, new object[] { model, weight, price, additionalParameter});
            return partInstance;
        }
    }
}
