﻿namespace StoreManagment;

internal class BuyItem : BaseModel
{
    private static int AutoIncremendId = 1;
    public Product Product { get; set; }
    public int Count {  get; set; }
    public decimal Total {  get; }

    public BuyItem(Product product, int count)
    {
        Product = product;
        Count = count;
        Total = product.Price * count;
        Id = AutoIncremendId++;
    }

}