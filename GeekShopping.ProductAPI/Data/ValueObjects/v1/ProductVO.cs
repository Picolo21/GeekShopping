namespace GeekShopping.ProductAPI.Data.ValueObjects.v1;

public class ProductVO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }
    public string? Description { get; set; }
    public string? CategoryName { get; set; }
    public string? ImageUrl { get; set; }
}
