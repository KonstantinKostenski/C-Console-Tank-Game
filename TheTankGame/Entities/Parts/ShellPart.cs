namespace TheTankGame.Entities.Parts
{
    using Contracts;
    using System.Text;

    public class ShellPart : BasePart, IPart, IDefenseModifyingPart
    {
        public ShellPart(string model, double weight, decimal price, int defensemodifier)
            :base(model, weight, price)
        {
            this.DefenseModifier = defensemodifier;  
        }

        public int DefenseModifier { get; private set; }

    }
}