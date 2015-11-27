using System.Collections.Generic;
using System.Linq;

namespace TheSlum
{
    using Interfaces;
    class Healer : Character, IHeal
    {
        public const int DefaultHealthPoints = 75;
        public const int DefaultDefensePoints = 50;
        public const int DefaultHealingPoints = 60;
        public const int DefaultRange = 6;

        public int healingPoints;


        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, DefaultHealthPoints, DefaultDefensePoints, team, DefaultRange)
        {
            this.HealingPoints = DefaultHealingPoints;
        }

        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }
            set
            {
                this.healingPoints = value;
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
            this.HealingPoints += item.HealthEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.HealingPoints -= item.HealthEffect;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            targetsList = targetsList.OrderBy(f => f.HealthPoints);
            return targetsList.First<Character>(f => f.Team == this.Team && f  != this);
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.HealingPoints;
        }

    }
}

