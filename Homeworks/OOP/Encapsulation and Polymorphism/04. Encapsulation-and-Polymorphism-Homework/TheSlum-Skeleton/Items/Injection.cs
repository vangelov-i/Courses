
namespace TheSlum.Items
{
    class Injection : Bonus
    {
        private const int DefaultHealthEffect = 200;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultAttackEffect = 0;
        private const int DefaultTurnsWhileActive = 3;

        public Injection(string id)
            : base (id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Countdown = DefaultTurnsWhileActive;
            this.HasTimedOut = false;
        }

    }
}
