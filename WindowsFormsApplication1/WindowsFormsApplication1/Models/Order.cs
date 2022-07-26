using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public string OrderType { get; set; } //"Take away" or "Delivery"
        public bool IsPayed { get; set; }
        public virtual ICollection<OrderProduct> Products { get; set; } = new HashSet<OrderProduct>();
    }
}
