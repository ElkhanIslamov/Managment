namespace StoreManagment;

internal class Product : BaseModel
{
    private static int AutoIncremendId = 1;
    public string Name {  get; set; }
    public decimal Price { get; set; }
    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
        Id = AutoIncremendId++;
    }
}
