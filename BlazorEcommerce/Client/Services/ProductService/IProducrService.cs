namespace BlazorEcommerce.Client.Services.ProductService
{
    public interface IProducrService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
    }
}
