using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Enabled = false;
            radioButton1.Checked = true;
            DataGridViewButtonColumn buttonCol = new DataGridViewButtonColumn();
            buttonCol.HeaderText = "حذف";
            
            buttonCol.Text = "Don't appear";
            buttonCol.CellTemplate.Style.BackColor = Color.Red;

            //list<string> products = new list<string>();
            //string p1 = "بيتزا فراخ";
            //string p2 = "بيتزا لحم";
            //string p3 = "بيتزا خضار";
            //products.add(p1);
            //products.add(p2);
            //products.add(p3);

            //list<button> buttons = new list<button>();
            //int i = 0;
            //foreach (string e in products)
            //{
            //    buttons[i] = new button();
            //    buttons[i].text = e;
            //    buttons[i].location = new system.drawing.point(33, 12);
            //    buttons[i].name = "button" + i.tostring();
            //    buttons[i].size = new system.drawing.size(40, 91);
            //    buttons[i].tabindex = 5;
            //    buttons[i].text = e.tostring();
            //    buttons[i].usevisualstylebackcolor = true;

            //    //  buttons[i].location=


            //    i++;


            //}
            // button19
            dataGridView1.Columns.Add(buttonCol);

         //   dataGridView1
         // dataGridView1
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;

        }
    }
}
