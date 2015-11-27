
namespace TheSlum.Items
{
    class Injection : Bonus
    {
        public const int DefaultHealthEffect = 200;
        public const int DefaultDefenseEffect = 0;
        public const int DefaultAttackEffect = 0;
        public const int DefaultTurnsWhileActive = 3;

        public Injection(string id)
            : base (id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Timeout = DefaultTurnsWhileActive;
            this.Countdown = Timeout;
            this.HasTimedOut = false;
        }

    }
}
