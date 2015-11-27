using System.Collections.Generic;
using System.Linq;

namespace TheSlum
{
    using Interfaces;
    class Mage : Character, IAttack
    {
        public const int DefaultHealthPoints = 150;
        public const int DefaultDefensePoints = 50;
        public const int DefaultAttackPoints = 300;
        public const int DefaultRange = 5;

        public int attackPoints;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.AttackPoints = DefaultAttackPoints;
        }


        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            set
            {
                this.attackPoints = value;
            }
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }


        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.AttackPoints += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.AttackPoints -= item.AttackEffect;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault<Character>(f => f.Team != this.Team && f.IsAlive == true && f != this);
        }


        public override string ToString()
        {
            return base.ToString() + ", Attack: " + this.AttackPoints;
        }

    }
}
