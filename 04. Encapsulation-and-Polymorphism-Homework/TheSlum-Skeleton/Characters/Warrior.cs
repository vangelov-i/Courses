using System.Collections.Generic;
using System.Linq;

namespace TheSlum
{
    using Interfaces;
    class Warrior : Character, IAttack
    {
        public const int DefaultHealthPoints = 200;
        public const int DefaultDefensePoints = 100;
        public const int DefaultAttackPoints = 150;
        public const int DefaultRange = 2;

        public int attackPoints;


        public Warrior(string id, int x, int y, Team team)
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
            this.AttackPoints += item.AttackEffect;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.FirstOrDefault<Character>(f => f.Team != this.Team && f.IsAlive == true && f != this);
        }


        // can't figure why this override isn't working ?!??
        public override string ToString()
        {
            return base.ToString() + ", Attack" + this.AttackPoints;
        }
    }
}
