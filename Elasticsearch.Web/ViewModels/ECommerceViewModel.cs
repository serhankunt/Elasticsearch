namespace Elasticsearch.Web.ViewModels;

public class ECommerceViewModel
{

    public string Id { get; set; } = default!;
    public string CustomerFirstName { get; set; } = default!;
    public string CustomerLastName { get; set; } = default!;
    public string CustomerFullName { get; set; } = default!;
    public string Gender { get; set; } = default!;

    public double TaxfulTotalPrice { get; set; }
    public string Category { get; set; } = default!;
    public int OrderId { get; set; } = default!;
    public string OrderDate { get; set; } = null!;
}
