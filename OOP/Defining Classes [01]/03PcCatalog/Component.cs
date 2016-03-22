using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Component
{
    string name;
    string details;
    decimal price;

    public Component(string name, string details, decimal price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }
    public Component(string name, decimal price)
        : this(name, null, price)
    {
    }
    public Component()
    {
    }

    public string Name 
    {
        get { return this.name; }
        set
        {
            if (value == "") //  || value.Any(x => !char.IsLetter(x))
            {
                throw new ArgumentException("Name", "Invalid name");
            } 
            this.name = value;
        } 
    }
    public string Details 
    {
        get { return this.details; }
        set
        {
            if (value == "") //  || value.Any(x => !char.IsLetter(x))
            {
                throw new ArgumentException("Details", "Invalid details");
            }
            this.details = value;
        }
    }
    public decimal Price 
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price", "Price takes only non-negative values");
            }
            this.price = value;
        }
    }


}