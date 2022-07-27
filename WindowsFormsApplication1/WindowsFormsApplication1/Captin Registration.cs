using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Repositories;

namespace WindowsFormsApplication1
{
    public partial class Captin_Registration : Form
    {
        IGenericRepository<Captain> repo = new GenericRepository<Captain>(new DataContext());
        public Captin_Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            repo.Add(new Captain {
                Name = textBox2.Text,
                Number = int.Parse(textBox3.Text)
            });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
