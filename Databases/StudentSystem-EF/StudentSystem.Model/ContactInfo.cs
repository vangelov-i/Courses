namespace StudentSystem.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [ComplexType]
    public class ContactInfo
    {
        [Column("Number")]
        [MinLength(5)]
        [MaxLength(20)]
        public string Number { get; set; }

        [Column("E-mail")]
        [MinLength(5)]
        [MaxLength(40)]
        public string Email { get; set; }

        [Column("Skype")]
        [MinLength(5)]
        [MaxLength(40)]
        public string Skype { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Phone Number: {0}{1}E-mail: {2}{1}Skype: {3}",
                this.Number,
                Environment.NewLine,
                this.Email,
                this.Skype);
        }
    }
}