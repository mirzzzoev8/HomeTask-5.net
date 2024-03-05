using Domain.Models;
using Infrastructure.Services;

var service = new ClientServices();
// var client = new Clients();
// client.Id = 1;
// client.Name = "Yusufjon";
// client.Balance = 1000;
// service.AddClient(client);

// var client1 = new Clients();
// client1.Id = 2;
// client1.Name = "Abu";
// client1.Balance = 2000;
// service.AddClient(client1);

// var transaction = new Transactions();
// transaction.Id = 1;
// transaction.Data = 2024;
// transaction.Summa = 1000;
// transaction.SenderId = 1;
// transaction.TakerId = 2;
// service.AddTransaction(transaction);

// var transaction1 = new Transactions();
// transaction1.Id = 2;
// transaction1.Data = 2024;
// transaction1.Summa = 100;
// transaction1.SenderId = 1;
// transaction1.TakerId = 2;
// service.AddTransaction(transaction1);

// foreach (var i in service.AllFinancialOperations())
// {
//         System.Console.WriteLine("Transaction:" + i.Id);
//         System.Console.WriteLine("Sender:" + i.SenderId);
//         System.Console.WriteLine("Taker:" + i.TakerId);
//         System.Console.WriteLine("Summa:" + i.Summa);
//         System.Console.WriteLine("Date of transaction:" + i.Data);
// }

// foreach (var i in service.TransactionHistory(1))
// {
//         System.Console.WriteLine("Transaction:" + i.Id);
//         System.Console.WriteLine("Sender:" + i.SenderId);
//         System.Console.WriteLine("Taker:" + i.TakerId);
//         System.Console.WriteLine("Summa:" + i.Summa);
//         System.Console.WriteLine("Date of transaction:" + i.Data);
// }


service.Functions(1,2,200);
service.Functions(2,1,500);
service.Functions(2,2,1200);



