namespace OOPExam.Interfaces
{
    /// <summary>
    /// Unit which is mortal and can be 
    /// killed/destroyed by applying attack to it.
    /// </summary>
    public interface IDestroyableUnit
    {
        int Health { get; set; }
    }
}
