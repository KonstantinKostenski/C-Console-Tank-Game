namespace TheTankGame.Entities.Parts
{
    using Contracts;
    using System.Text;

    public class ArsenalPart : BasePart, IPart, IAttackModifyingPart
    {
        public ArsenalPart(string model, double weight, decimal price, int attackModifier)
            : base(model, weight, price)
        {
            this.AttackModifier = attackModifier;
        }

        public int AttackModifier { get; private set; }

    }
}