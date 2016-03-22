using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Laptop
{
    private string model;
    private string manufact;
    private string processor;
    private int ram;
    private string graphics;
    private string hdd;
    private string screen;
    private Battery battery = new Battery();
    private decimal price;

    public Laptop(string model, string manufact, string processor, int ram, string graphics,
                string hdd, string screen, Battery battery, decimal price)
    {
        this.Model = model;
        this.Manufact = manufact;
        this.Processor = processor;
        this.Ram = ram;
        this.Graphics = graphics;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.Price = price;
    }
    public Laptop(string model, decimal price)
        : this(model, null, null, 0, null, null, null, new Battery(), price)
    {
    }
    // model, proc, hdd, price
    public Laptop(string model, string processor, string hdd, decimal price)
        : this(model, null, processor, 0, null, hdd, null, new Battery(), price)
    {
    }
    // model, manuf, proc, ram, hdd, screen, price
    public Laptop(string model, string manufact, string processor, int ram,
            string hdd, string screen, decimal price)
        : this(model, manufact, processor, ram, null, hdd, screen, new Battery(), price)
    {
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Model","Model takes no empty inputs");
            } 
            this.model = value;
        }
    }
    public string Manufact
    {
        get { return this.manufact; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Manufactorer", "Manufacturer takes no empty inputs");
            }
        this.manufact = value; } }
    public string Processor
    {
        get { return this.processor; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Processor", "Processor takes no empty inputs");
            } 
            this.processor = value;
        }
    }
    public int Ram
    {
        get { return this.ram; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("RAM", "RAM takes no negative value");
            } 
            this.ram = value;
        }
    }
    public string Graphics
    {
        get { return this.graphics; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Graphics", "Graphics takes no empty inputs");
            }
            this.graphics = value;
        }
    }
    public string Hdd
    {
        get { return this.hdd; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("HDD", "HDD takes no empty inputs");
            }
            this.hdd = value;
        }
    }
    public string Screen
    {
        get { return this.screen; }
        set
        {
            if (value == "")
            {
                throw new ArgumentNullException("Screen", "Screen takes no empty inputs");
            }
            this.screen = value;
        }
    }
    public Battery Battery { get { return this.battery; } set { this.battery = value; } }
    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price", "Price takes no negative value");
            }
            this.price = value;
        }
    }

    public override string ToString()
    {
        return string.Format
            (
            "model: {0}\n" + "manufacturer: {1}\n" + "processor: {2}\n" + "RAM: {3}\n" +
            "graphics card: {4}\n" + "HDD: {5}\n" + "screen: {6}\n" + "battery: {7}\n" + "battery life: {8}\n" +
            "price: {9:F2} lv.\n", this.model, this.manufact ?? "no info",
            this.processor ?? "no info", this.ram != 0 ? this.ram.ToString() + " GB" : "no info", this.graphics ?? "no info", this.hdd ?? "no info", this.screen ?? "no info", this.battery.Type ?? "no info",
            this.battery.Life != 0 ? this.battery.Life.ToString() + " hours" : "no info", this.price
            );
    }

}
