
using System;public class Product : IComparable<Product>
{
    public Product(int id, string title, string suplier, decimal price)
    {
        this.Id = id;
        this.Title = title;
        this.Suplier = suplier;
        this.Price = price;
    }

    public int Id { get; set; }

    public string Title { get; set; }

    public string Suplier { get; set; }

    public decimal Price { get; set; }

    public int CompareTo(Product other)
    {
        return this.Id.CompareTo(other.Id);
    }

    public override bool Equals(object obj)
    {
        Product other = obj as Product;
        if (other == null)
        {
            return false;
        }

        bool result = 
            this.Id == other.Id && 
            this.Title == other.Title && 
            this.Suplier == other.Suplier && 
            this.Price == other.Price;

        return result;
    }

    public override string ToString()
    {
        return string.Format("{0}|{1}|{2}", this.Id, this.Title, this.Price);
    }
}