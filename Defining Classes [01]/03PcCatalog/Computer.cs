using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Computer
{
    private string name;
    private Component processor = new Component();
    private Component graphics = new Component();
    private Component card = new Component();
    private Component motherboard = new Component();
    private decimal totalPrice;

    public Computer(string name, Component processor, Component graphics, Component card, Component motherboard)
    {
        this.Name = name;
        this.Processor = processor;
        this.Graphics = graphics;
        this.Card = card;
        this.Motherboard = motherboard;
        this.TotalPrice = totalPrice;
    }
    public Computer(string name, Component processor, Component motherboard) 
        : this (name, processor, new Component(), new Component(), motherboard)
    {
    }
    public string Name 
    {
        get { return this.name; }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("Name", "Invalid name");
            }
            this.name = value;
        }
    }
    public Component Processor 
    {
        get { return this.processor; }
        set { this.processor = value; }
    }
    public Component Graphics 
    {
        get { return this.graphics; }
        set { this.graphics = value; }
    }
    public Component Card 
    {
        get { return this.card; }
        set { this.card = value; }
    }
    public Component Motherboard 
    {
        get { return this.motherboard; }
        set { this.motherboard = value; }
    }

        public decimal TotalPrice 
    {
        get { return this.totalPrice; }
        set { this.totalPrice = processor.Price + graphics.Price + card.Price + motherboard.Price; }
    }


    public override string ToString()
    {
        //decimal totalPrice = processor.Price + graphics.Price + card.Price + motherboard.Price;
        return string.Format
            (
            "Name: {0}\n" + "Proessor: {1} /price: {2}\n" + "Graphics: {3} /price: {4}\n" + "Card: {5} /price: {6}\n" +
            "Motherboard: {7} /price: {8}\n" + "Total price: {9}", this.name ?? "no info", 
            this.processor.Name ?? "no info", this.processor.Price != 0 ? this.processor.Price.ToString() : "no info",
            this.graphics.Name ?? "no info", this.graphics.Price != 0 ? this.graphics.Price.ToString() : "no info", 
            this.card.Name ?? "no info", this.card.Price != 0 ? this.card.Price.ToString() : "no info", 
            this.motherboard.Name ?? "no info", this.motherboard.Price != 0 ? this.motherboard.Price.ToString() : "no info",
            this.TotalPrice
            );
    }
}