namespace OOPExam.Interfaces
{
    /// <summary>
    /// Defines what kind special abilities the object 
    /// has and gives the opportunity to apply it's effect.
    /// </summary>
    public interface IBehavior
    {
        string Behavior { get; }

        void ApplyBehavior();
    }
}
