using System.Text.Json.Serialization;

namespace Elasticsearch.Web.Models;

public class ECommerce
{
    [JsonPropertyName("_id")]
    public string Id { get; set; } = default!;
    [JsonPropertyName("customer_first_name")]
    public string CustomerFirstName { get; set; } = default!;
    [JsonPropertyName("customer_last_name")]
    public string CustomerLastName { get; set; } = default!;
    [JsonPropertyName("customer_full_name")]
    public string CustomerFullName { get; set; } = default!;

    [JsonPropertyName("customer_gender")]
    public string Gender { get; set; } = default!;

    [JsonPropertyName("taxful_total_price")]
    public double TaxfulTotalPrice { get; set; }
    [JsonPropertyName("category")]
    public string[] Category { get; set; } = default!;
    [JsonPropertyName("order_id")]
    public int OrderId { get; set; } = default!;
    [JsonPropertyName("order_date")]
    public DateTime OrderDate { get; set; }
    [JsonPropertyName("products")]
    public Product[] Products { get; set; }
}

public class Product
{
    [JsonPropertyName("product_id")]
    public long ProductId { get; set; }
    [JsonPropertyName("product_name")]
    public string ProductName { get; set; } = default!;
}