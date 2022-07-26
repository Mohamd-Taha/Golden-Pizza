using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class BuyBill
    {
        public int Id { get; set; }
        public Trader Trader { get; set; }
        public int TraderId  { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public virtual ICollection<BuyBillItem> Items { get; set; } = new HashSet<BuyBillItem>();
    }
}
