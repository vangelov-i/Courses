namespace StudentSystem.Model.CustomAttributes
{
    using System.ComponentModel.DataAnnotations;

    public class MaxValueAttribute : ValidationAttribute
    {
        private readonly int maxValue;

        public MaxValueAttribute(int maxValue)
        {
            this.maxValue = maxValue;
        }

        public override bool IsValid(object value)
        {
            return (int)value <= this.maxValue;
        }
    }
}