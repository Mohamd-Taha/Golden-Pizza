using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.Models;

namespace WindowsFormsApplication1
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=con")
        {

        }

        public DbSet<BuyBill> buyBills { get; set; }
        public DbSet<BuyBillItem> buyBillItems { get; set; }
        public DbSet<Captain> captains { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderProduct> orderProducts { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Shift> shifts { get; set; }
        public DbSet<Trader> traders { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<WalletTransaction> walletTransactions { get; set; }





    }
}
