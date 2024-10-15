using System.ComponentModel;

public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public string GetCustomerName()
    {
        return name;
    }

    public string GetAddressString()
    {
        return address.GetAddressString();
    }
}