public class Order
{
private List<Product> _productsList;
private Customer _customer;
private float _shippingCost;

public Order(Customer customer, List<Product> products)
{
    _customer = customer;
    _productsList = products;
}

public string CalculateTotalCost()
{
    float total = 0;
    foreach (var product in _productsList)
    {
        total += product.CalculateTotalCost();
    }

    _shippingCost = _customer.IsInUSA() ? 5 : 35;
    return $"Total: ${total}\nShipping: ${_shippingCost}\nFinal Price: ${total + _shippingCost}";
}

public string GetPackingLabel()
{
    int productNumber = 1;
    string label = "PACKING LABEL:";
    string products = "";

    foreach (var product in _productsList)
    {
        products += $"Product Number: {productNumber}\n{product.GetProductDetails()}";
        if (productNumber < _productsList.Count) 
        {
            products += "\n\n"; 
        }
        productNumber += 1;
    }
    return $"{label}\n{products}";
}

public string GetShippingLabel()
{
    return $"Shipping Label:\n{_customer.GetCustomerInfo()}";
}
    
}