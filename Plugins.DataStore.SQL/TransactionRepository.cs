using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.SQL
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly MarketContext db;

        public TransactionRepository(MarketContext db)
        {
            this.db = db;
        }

        public IEnumerable<Transaction> Get(string cashierName)
        {
            return db.Transactions.ToList();
        }

        public IEnumerable<Transaction> GetByDay(string cashierName, DateTime date)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => x.TimeStamp.Date == date.Date);
            else
                return db.Transactions.Where(x => 
                x.CashierName.ToLower() == cashierName.ToLower()
                && x.TimeStamp.Date == date.Date);
        }

        public void Save(string cashierName, int productId, string productName, double price, int beforeSoldQty, int soldQty)
        {
            var transactoin = new Transaction
            {
                ProductId = productId,
                ProductName = productName,
                TimeStamp = DateTime.Now,
                Price = price,
                BeforeQty = beforeSoldQty,
                SoldQuantity = soldQty,
                CashierName = cashierName
            };
            db.Transactions.Add(transactoin);
            db.SaveChanges();

        }

        public IEnumerable<Transaction> Search(string cashierName, DateTime startDate, DateTime endDate)
        {
            if (string.IsNullOrWhiteSpace(cashierName))
                return db.Transactions.Where(x => x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
            else
                return db.Transactions.Where(x =>
                x.CashierName.ToLower() == cashierName.ToLower() &&
                x.TimeStamp >= startDate.Date && x.TimeStamp <= endDate.Date.AddDays(1).Date);
        }
    }
}
