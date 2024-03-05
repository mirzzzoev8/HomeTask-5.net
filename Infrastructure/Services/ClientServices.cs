using Dapper;
using Domain.Models;
using Infrastructure.DataContext;

namespace Infrastructure.Services;

public class ClientServices
{
    private readonly DapperContext _context;

    public ClientServices()
    {
        _context = new DapperContext();
    }
    public void AddClient(Clients clients)
    {
        var query = "insert into Clients (Id, Name, Balance) VALUES (@Id, @Name, @Balance)";
        _context.Connection().Execute(query, clients);
        System.Console.WriteLine("Client added succesfuly !!!");
        
    }
    public void AddTransaction(Transactions transactions)
    {
        var query = "insert into Transactions (Id, Data, Summa, SenderId, TakerId) VALUES (@Id, @Data, @Summa, @SenderId, @TakerId)";
        _context.Connection().Execute(query, transactions);
        System.Console.WriteLine("Transactions added succesfuly !!!");
        
    }
    public void Functions(int senderId, int takerId, decimal sum )
    {
        var query1 = " update clients set Balance = Balance - @summa where @Id = @senderId ";
        var query2 = " update clients set Balance = Balance + @summa where @Id = @takerId ";
        _context.Connection().Execute(query1, new {Summa = sum, SenderId = senderId});
        _context.Connection().Execute(query2, new {Summa = sum, TakerId = takerId});
    }

    public List<Transactions> TransactionHistory(int id)
    {
            var query = "select * from transactions where SenderId = @Id or TakerID = @Id";
            return  _context.Connection().Query<Transactions>(query, new { Id = id }).ToList();
    }


    public List<Transactions> AllFinancialOperations()
    {
        var query = "select * from Transactions";
        return _context.Connection().Query<Transactions>(query).ToList();
    }   
    
}
