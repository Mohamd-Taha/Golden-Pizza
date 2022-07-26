using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiredDate { get; set; }
        public string UserName { get; set; } //"Unique" 
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
