using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Battery
{
    private string type;
    private decimal life;

    public Battery()
    {
    }
    public Battery(string battery, decimal batLife)
    {
        this.Type = battery;
        this.Life = batLife;
    }
    public string Type
    {
        get { return this.type; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Battery type", "Battery type takes no empty inputs");
            }
            this.type = value;
        }
    }
    public decimal Life
    {
        get { return this.life; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Battery life", "Battery life takes no negative inputs");
            }
            this.life = value;
        }
    }


}
