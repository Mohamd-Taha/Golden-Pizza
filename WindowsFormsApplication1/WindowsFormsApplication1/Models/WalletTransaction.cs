using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class WalletTransaction
    {
        public int Id { get; set; }
        public string TransactionType { get; set; } //"ADD" or "MINUS"
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public int CurrentState { get; set; }
    }
}
