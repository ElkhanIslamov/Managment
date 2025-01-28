namespace StoreManagment;

internal class Seller : Person
{
    private static int AutoIncremendId = 1;
    public int StoreId {  get; set; }
    public Seller(string name, int storeId) : base(name)
    {
        StoreId = storeId;
        Id = AutoIncremendId++;
    }
}
