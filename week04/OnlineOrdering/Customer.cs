public class Customer
{
    private string _name;
    private Address _address;

    //CONSTRUCTOR
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //METHOD
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public bool LivesInUsa()
    {
        return _address.IsInUsa();
    }
}