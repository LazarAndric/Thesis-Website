
public class GenderOfProduct
{
    public int Id { get; set; }
    public int? ProductId { get; set; }
    public Product Product { get; set; }
    public int? GenderId { get; set; }
    public Gender Gender { get; set; }
}