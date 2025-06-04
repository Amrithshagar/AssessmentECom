public class ProductItems
{
    private int Id { get; set; }
    private string Name { get; set; }
    private int Price { get; set; }

}
public interface IProductService
{
    ProductItems AddProducts(string name);
    List<ProductItems> GetAll();
    

}

public class ProductService : IProductService
{
    private readonly List<ProductItems> AddedProducts = new();
    private int ViewId = 1;
    private int ViewPrice = 0;
    public ProductItems AddProducts(string name)
    {
        var product = new ProductItems
        {
            Id = ViewId,
            Name = name,
            Price = price
        };
        AddedProducts.Add(product);
        return product;

    }
    public List<ProductItems> GetAll();

}

public class Test
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        
        app.Run();
        app.MapPost("/products", (string title, IProductService service) =>
        {
            var product = service.AddProducts(title);
            return Results.Ok(product);
            
        });

        app.MapGet("/products", (IProductService service) =>
        {
            return Results.Ok(service.GetAll());
        });

        app.MapPut("/prpoducts/{id}", (int id, IProductService service) =>
        {
            return Results.Ok("Product Added");
        });
        
    }
}
