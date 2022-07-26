using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class Shift
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
        public string ShiftType { get; set; } //"night" or "morning"
        public int MoneyEarned { get; set; }

    }
}
