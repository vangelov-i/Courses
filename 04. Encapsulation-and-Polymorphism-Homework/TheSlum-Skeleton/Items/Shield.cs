
namespace TheSlum.Items
{
    public class Shield : Item
    {
        public const int DefaultHealthEffect = 0;
        public const int DefaultDefenseEffect = 50;
        public const int DefaultAttackEffect = 0;

        public Shield(string id)
            : base(id, DefaultHealthEffect, DefaultDefenseEffect, DefaultAttackEffect)
        {
        }

    }
}
