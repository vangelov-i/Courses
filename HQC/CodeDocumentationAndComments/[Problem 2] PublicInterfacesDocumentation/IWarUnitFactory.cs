namespace OOPExam.Interfaces
{
    /// <summary>
    /// A place where different kind of war 
    /// units (IWarUnit) can be produced.
    /// </summary>
    public interface IWarUnitFactory
    {
        IWarUnit ProduceWarUnit(
            string name,
            int health,
            int damage,
            string behavior,
            string specialAttackType
            );
    }
}
