namespace TheTankGame.Entities.Miscellaneous
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Parts.Contracts;
    using TheTankGame.Entities.Parts;

    public class VehicleAssembler : IAssembler
    {
        private readonly List<IAttackModifyingPart> arsenalParts;
        private readonly List<IDefenseModifyingPart> shellParts;
        private readonly List<IHitPointsModifyingPart> enduranceParts;

        public VehicleAssembler()
        {
            this.arsenalParts = new List<IAttackModifyingPart>();
            this.shellParts = new List<IDefenseModifyingPart>();
            this.enduranceParts = new List<IHitPointsModifyingPart>();
        }

        public IReadOnlyCollection<IAttackModifyingPart> ArsenalParts
                                => this.arsenalParts.AsReadOnly();

        public IReadOnlyCollection<IDefenseModifyingPart> ShellParts
                                => this.shellParts.AsReadOnly();

        public IReadOnlyCollection<IHitPointsModifyingPart> EnduranceParts
                                => this.enduranceParts.AsReadOnly();

        public double TotalWeight
                         => this.ArsenalParts.Sum(p => p.Weight) +
                            this.ShellParts.Sum(p => p.Weight) +
                            this.EnduranceParts.Sum(p => p.Weight);

        public decimal TotalPrice
                         => this.ArsenalParts.Sum(p => p.Price) +
                            this.ShellParts.Sum(p => p.Price) +
                            this.EnduranceParts.Sum(p => p.Price);

        public long TotalAttackModification
             => this.ArsenalParts.Sum(p => p.AttackModifier);

        public long TotalDefenseModification
             => this.ShellParts.Sum(p => p.DefenseModifier);

        public long TotalHitPointModification
             => this.EnduranceParts.Sum(p => p.HitPointsModifier);

        public void AddArsenalPart(IPart arsenalPart)
        {
            ArsenalPart part = (ArsenalPart)arsenalPart;
            this.arsenalParts.Add(part);
        }

        public void AddShellPart(IPart shellPart)
        {
            ShellPart part = (ShellPart)shellPart;

            this.shellParts.Add(part);
        }

        public void AddEndurancePart(IPart endurancePart)
        {
            EndurancePart part = (EndurancePart)endurancePart;

            this.enduranceParts.Add(part);
        }
    }
}