using System.Diagnostics.Contracts;

public class Product
{
    private string name;
    private string productID;
    private decimal price;
    private int quantity;

    public Product(string name, string productID, decimal price, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.price = price;
        this.quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return price * quantity;
    }

    public string GetPackingLabel()
    {
        return $"{name} (Product ID: {productID})";
    }
}