namespace OOPExam.Interfaces
{
    /// <summary>
    /// Unit which can apply attack to a destroyable target.
    /// </summary>
    public interface IAttackingUnit
    {
        void Attack(IDestroyableUnit target);
    }
}