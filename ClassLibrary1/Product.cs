﻿

namespace ClassLibrary1;

public class Product
{
public int Id { get; set; } 
public string Name { get; set; }
public string? Description { get; set; }
public int CategoryId { get; set; }
public decimal Price { get; set; }  
public  Category? Category { get; set; } // navigation property ile bu ürünün 1 kategorisi olduğunu belirtir ve kategori ile ürün arasında bağlantı kurarız.
}
