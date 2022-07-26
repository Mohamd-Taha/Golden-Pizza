using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class BuyBillItem
    {
        public int Id { get; set; }
        public BuyBill BuyBill { get; set; }
        public int BuyBillId { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
    }
}
