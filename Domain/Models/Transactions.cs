namespace Domain.Models;

public class Transactions
{
    public int Id { get; set; }
    public int Data { get; set; }
    public decimal Summa { get; set; }
    public int SenderId { get; set; }
    public int TakerId { get; set; }
}
