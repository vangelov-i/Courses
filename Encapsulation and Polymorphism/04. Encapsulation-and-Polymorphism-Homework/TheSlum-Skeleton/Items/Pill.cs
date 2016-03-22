
namespace TheSlum.Items
{
    class Pill : Bonus
    {
        private const int DefaultAttackEffect = 100;
        private const int DefaultDefenseEffect = 0;
        private const int DefaultHealthEffect = 0;
        private const int DefaultTurnsWhileActive = 1;
        

        public Pill(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
            this.Countdown = DefaultTurnsWhileActive;
            this.HasTimedOut = false;
        }


    }
}
