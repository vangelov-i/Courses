namespace OOPExam.Interfaces
{
    /// <summary>
    /// IWarUnit defines all units used for a battle.
    /// It can attack by using normal or special attack by 
    /// applying it's damage. It can be destroyed, updated. 
    /// </summary>
    public interface IWarUnit : IDestroyableUnit, IAttackingUnit, IBehavior, ISpecialAttackType, IUpdatable
    {
        string Name { get; }
        int Damage { get; }
    }
}