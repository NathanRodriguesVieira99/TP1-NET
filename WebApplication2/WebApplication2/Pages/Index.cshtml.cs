using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    public List<Product> Products { get; set; }

    public void OnGet()
    {
        Products = new List<Product>
        {
            new Product { Name = "GTA 6", Price = 800 },
            new Product { Name = "Camisa do Vasco", Price = 450 },
            new Product { Name = "Merch Sepultura", Price = 1000 }
        };
    }
}

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
