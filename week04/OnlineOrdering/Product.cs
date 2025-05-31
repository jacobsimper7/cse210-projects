class Product
{

    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id, double price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public int GetTotalPrice()
    {
        return (int)(_price * _quantity);
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }   
    
}