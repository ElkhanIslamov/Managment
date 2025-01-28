namespace StoreManagment;

internal class Person : BaseModel
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
}