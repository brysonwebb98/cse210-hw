public class Product 
{
    private string _productName;
    private string _productID;
    private float _pricePerUnit;
    private int _quantity;

    public Product(string name, string ID, float price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public float CalculateTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetProductDetails()
    {
        return $"Product: {_productName}\nID Number: {_productID}";
    }

    public string GetProductID()
    {
        return _productID;
    }

}