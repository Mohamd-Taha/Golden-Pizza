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
    public partial class Test : Form
    {
        //List<string> products;
        //List<Button> buttons;

        List<string> products = new List<String>();
        List<Button> buttons = new List<Button>();
        public void PopulateProductList()
        {
            string p1 = "بيتزا فراخ";
            string p2 = "بيتزا لحم";
            string p3 = "بيتزا خضار";
            string p4 = "بيتزا مارجريتا";
            string p5 = "بيتزا سجق";
            string p6 = "بيتزا كبده";
            string p7 = "بيتزا شاورما";
            string p8 = "بيتزا شيش";

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);
            products.Add(p5);
            products.Add(p6);
            products.Add(p7);
            products.Add(p8);


        }
        public Test()
        {
            InitializeComponent();
            PopulateProductList();

            int i = 0;
            int VerticalCounter = 0;
            int VerticalLocation = 120;
            int HorizontalLocation = 20;
            foreach (string e in products)
            {

                buttons.Add(new Button());
                buttons[i].Text = e;
                if(VerticalCounter>3)
                {
                    VerticalCounter = 0;
                    VerticalLocation += 80;
                    HorizontalLocation = 30;


                }
                buttons[i].Location = new System.Drawing.Point(HorizontalLocation, VerticalLocation);
                buttons[i].Name = "button" + i.ToString();
                buttons[i].Size = new System.Drawing.Size(60, 60);
                buttons[i].TabIndex = i;
                buttons[i].Text = e.ToString()+ Environment.NewLine +"("+ (i*10).ToString()+")";
                buttons[i].UseVisualStyleBackColor = true;
                Controls.Add(buttons[i]);

                i++;
                HorizontalLocation += 60;
                VerticalCounter += 1;



            }
        }
    }
}
