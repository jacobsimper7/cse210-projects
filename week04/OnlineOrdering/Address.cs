class Address
{
    private string _street { get; set; }
    private string _city { get; set; }
    private string _state { get; set; }
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUSA()
    {
        if (_country.ToLower() == "usa" || _country.ToLower() == "united states")
        {
            return true;
        }
        return false;
    }

    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
    
    public string GetCountry()
    {
        return _country;
    }
}