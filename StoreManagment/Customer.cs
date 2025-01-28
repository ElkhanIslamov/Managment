namespace StoreManagment;

internal class Customer : Person
{
    private static int AutoIncremendId = 1;
    public int Age {  get; set; }
    public Customer(string name, int age) : base(name)
    {
        Age = age;
        Id = AutoIncremendId++;
    }
}
