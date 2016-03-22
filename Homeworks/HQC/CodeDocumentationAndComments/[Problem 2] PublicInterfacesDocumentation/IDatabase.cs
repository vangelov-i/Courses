namespace OOPExam.Interfaces
{
    /// <summary>
    /// IDatabase keeps track of the existing war units(IWarUnit).
    /// </summary>
    public interface IDatabase
    {
        IEnumerable<IWarUnit> WarUnits { get; }

        void AddWarUnit(IWarUnit warUnit);
    }
}
