namespace StudentSystem.Model.CustomAttributes
{
    using System.ComponentModel.DataAnnotations;

    public class MinValueAttribute : ValidationAttribute
    {
        private readonly int minValue;

        public MinValueAttribute(int minValue)
        {
            this.minValue = minValue;
        }

        public override bool IsValid(object value)
        {
            return (int)value >= this.minValue;
        }
    }
}