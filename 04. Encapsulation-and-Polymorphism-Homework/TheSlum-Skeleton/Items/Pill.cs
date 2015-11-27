
namespace TheSlum.Items
{
    class Pill : Bonus
    {
        public const int DefaultAttackEffect = 100;
        public const int DefaultDefenseEffect = 0;
        public const int DefaultHealthEffect = 0;
        public const int DefaultTurnsWhileActive = 1;


        public Pill(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Timeout = DefaultTurnsWhileActive;
            this.Countdown = Timeout;
            this.HasTimedOut = false;
        }


    }
}
