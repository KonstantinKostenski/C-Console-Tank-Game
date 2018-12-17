namespace TheTankGame.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;
    using System.Reflection;
    using TheTankGame.Entities.Miscellaneous;
    using TheTankGame.Entities.Parts;
    using TheTankGame.Entities.Vehicles;

    [TestFixture]
    public class BaseVehicleTests
    {
        [Test]
        public void IsModelInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            Vanguard vanguard = new Vanguard(model, weight, price, attack, defense, hitPoints, assembler);


            string actualValue = vanguard.Model;

            string expectedValue = "testModel";

            Assert.AreEqual(expectedValue, actualValue);
            
        }
        [Test]
        public void IsAttackInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            Vanguard vanguard = new Vanguard(model, weight, price, attack, defense, hitPoints, assembler);


            int actualValue = vanguard.Attack;

            int expectedValue = 23;

            Assert.AreEqual(expectedValue, actualValue);

        }
        [Test]
        public void IsWeightInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            Vanguard vanguard = new Vanguard(model, weight, price, attack, defense, hitPoints, assembler);


            double actualValue = vanguard.Weight;

            double expectedValue = 23;

            Assert.AreEqual(expectedValue, actualValue);

        }
        [Test]
        public void IsPriceInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            Vanguard vanguard = new Vanguard(model, weight, price, attack, defense, hitPoints, assembler);


            decimal actualValue = vanguard.Price;

            decimal  expectedValue = 23m;

            Assert.AreEqual(expectedValue, actualValue);

        }
        [Test]
        public void IsDefenseInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            Vanguard vanguard = new Vanguard(model, weight, price, attack, defense, hitPoints, assembler);


            int actualValue = vanguard.Defense;

            int expectedValue = 23;

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void AreHitPointsInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            Vanguard vanguard = new Vanguard(model, weight, price, attack, defense, hitPoints, assembler);


            int actualValue = vanguard.HitPoints;

            int expectedValue = 23;

            Assert.AreEqual(expectedValue, actualValue);

        }

        [Test]
        public void IsModelExceptionInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = null;
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            

            Assert.Throws<ArgumentException>(() => new Revenger(model, weight, price, attack, defense, hitPoints, assembler));

        }
        [Test]
        public void IsAttackExceptionInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = null;
            double weight = 23;
            decimal price = 23m;
            int attack = -10;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();


            Assert.Throws<ArgumentException>(() => new Revenger(model, weight, price, attack, defense, hitPoints, assembler));

        }
        [Test]
        public void IsWeightExceptionInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = null;
            double weight = 0;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();


            Assert.Throws<ArgumentException>(() => new Revenger(model, weight, price, attack, defense, hitPoints, assembler));

        }
        [Test]
        public void IsPriceExceptionInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = null;
            double weight = 23;
            decimal price = 0;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();


            Assert.Throws<ArgumentException>(() => new Revenger(model, weight, price, attack, defense, hitPoints, assembler));

        }
        [Test]
        public void IsDefenseExceptionInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = null;
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = -1;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();


            Assert.Throws<ArgumentException>(() => new Revenger(model, weight, price, attack, defense, hitPoints, assembler));

        }

        [Test]
        public void IsHitPointsEceptionInitialisedCorrectly()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = null;
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = -1;
            VehicleAssembler assembler = new VehicleAssembler();


            Assert.Throws<ArgumentException>(() => new Revenger(model, weight, price, attack, defense, hitPoints, assembler));

        }

        [Test]
        public void TotalWeightTest()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            ArsenalPart part = new ArsenalPart(model, weight, price, attack);
            assembler.AddArsenalPart(part);
            var revenger = new Revenger(model, weight, price, attack, defense, hitPoints, assembler);
            double expectedResult = 46;
            double actualResult = revenger.TotalWeight;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void TotalPriceTest()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            ArsenalPart part = new ArsenalPart(model, weight, price, attack);
            assembler.AddArsenalPart(part);
            var revenger = new Revenger(model, weight, price, attack, defense, hitPoints, assembler);
            double expectedResult = 46;
            decimal actualResult = revenger.TotalPrice;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void TotalAttackTest()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            ArsenalPart part = new ArsenalPart(model, weight, price, attack);
            assembler.AddArsenalPart(part);
            var revenger = new Revenger(model, weight, price, attack, defense, hitPoints, assembler);
            double expectedResult = 46;
            long actualResult = revenger.TotalAttack;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void TotalDefenseTest()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            ArsenalPart part = new ArsenalPart(model, weight, price, attack);
            assembler.AddArsenalPart(part);
            var revenger = new Revenger(model, weight, price, attack, defense, hitPoints, assembler);
            int expectedResult = 23;
            long actualResult = revenger.TotalDefense;

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test]
        public void TotalHitpointsTest()
        {
            var type = typeof(BaseVehicle);
            //string model,double weight,decimal price, int attack,int defense,int hitPoints, IAssembler assembler
            string model = "testModel";
            double weight = 23;
            decimal price = 23m;
            int attack = 23;
            int defense = 23;
            int hitPoints = 23;
            VehicleAssembler assembler = new VehicleAssembler();
            ArsenalPart part = new ArsenalPart(model, weight, price, attack);
            assembler.AddArsenalPart(part);
            var revenger = new Revenger(model, weight, price, attack, defense, hitPoints, assembler);
            int expectedResult = 23;
            long actualResult = revenger.TotalHitPoints;

            Assert.AreEqual(expectedResult, actualResult);

        }


    }
}