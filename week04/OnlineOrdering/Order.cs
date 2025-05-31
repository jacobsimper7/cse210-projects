class Order
{
    private List<Product> _orderedProducts = new List<Product>();
    private Customer _customer; // Store the whole customer, not just the name

    public Order(Customer customer, List<Product> orderedProducts)
    {
        _customer = customer;
        _orderedProducts = orderedProducts;
    }

    public void AddProduct(Product product)
    {
        _orderedProducts.Add(product);
    }

    public int GetTotalPrice()
    {
        int totalPrice = 0;
        foreach (var product in _orderedProducts)
        {
            totalPrice += product.GetTotalPrice();
        }
        if (_customer.IsInUSA())
        {
            totalPrice += 5; // Add $5 shipping fee for USA customers
        }
        else
        {
            totalPrice += 35; // Add $10 shipping fee for non-USA customers
        }
        return totalPrice;
    }

    public string GetPackingLable()
    {
        string packingLabel = "";
        foreach (var product in _orderedProducts)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetId()}) - Quantity: {product.GetQuantity()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping to: {_customer.GetName()}\n" +
               $"Address: {_customer.GetAddress().GetFullAddress()}";
    }
}