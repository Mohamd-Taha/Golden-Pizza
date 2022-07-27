using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Manually_generated_form : System.Windows.Forms.Form
    {

    // Required designer variable.
    private System.ComponentModel.Container components;

        // Declare variables.
        private System.Windows.Forms.RadioButton tab3RadioButton2;
        private System.Windows.Forms.RadioButton tab3RadioButton1;
        private System.Windows.Forms.CheckBox tab2CheckBox3;
        private System.Windows.Forms.CheckBox tab2CheckBox2;
        private System.Windows.Forms.CheckBox tab2CheckBox1;
        private System.Windows.Forms.Label tab1Label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private List<System.Windows.Forms.Button> ButtonList;

        public Manually_generated_form()
        {
            // This call is required for Windows Form Designer support.
            InitializeComponent();
        }

        //foreach( int x in Dt)
          //  {


            
            
            
            
            
         //   }

    // This method is required for Designer support.
    private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab1Label1 = new System.Windows.Forms.Label();
            this.tab2CheckBox3 = new System.Windows.Forms.CheckBox();
            this.tab3RadioButton2 = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tab2CheckBox2 = new System.Windows.Forms.CheckBox();
            this.tab2CheckBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tab3RadioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tab1Label1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1418, 1101);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "وجبات";
            // 
            // tab1Label1
            // 
            this.tab1Label1.Location = new System.Drawing.Point(16, 24);
            this.tab1Label1.Name = "tab1Label1";
            this.tab1Label1.Size = new System.Drawing.Size(224, 96);
            this.tab1Label1.TabIndex = 1;
            this.tab1Label1.Text = "label1";
            // 
            // tab2CheckBox3
            // 
            this.tab2CheckBox3.Location = new System.Drawing.Point(32, 136);
            this.tab2CheckBox3.Name = "tab2CheckBox3";
            this.tab2CheckBox3.Size = new System.Drawing.Size(176, 32);
            this.tab2CheckBox3.TabIndex = 2;
            this.tab2CheckBox3.Text = "checkBox3";
            // 
            // tab3RadioButton2
            // 
            this.tab3RadioButton2.Location = new System.Drawing.Point(64, 196);
            this.tab3RadioButton2.Name = "tab3RadioButton2";
            this.tab3RadioButton2.Size = new System.Drawing.Size(182, 63);
            this.tab3RadioButton2.TabIndex = 1;
            this.tab3RadioButton2.Text = "radioButton2";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(26, 236);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1438, 1159);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tab2CheckBox3);
            this.tabPage2.Controls.Add(this.tab2CheckBox2);
            this.tabPage2.Controls.Add(this.tab2CheckBox1);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1418, 1101);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "بيتزا";
            // 
            // tab2CheckBox2
            // 
            this.tab2CheckBox2.Location = new System.Drawing.Point(32, 80);
            this.tab2CheckBox2.Name = "tab2CheckBox2";
            this.tab2CheckBox2.Size = new System.Drawing.Size(176, 32);
            this.tab2CheckBox2.TabIndex = 1;
            this.tab2CheckBox2.Text = "checkBox2";
            // 
            // tab2CheckBox1
            // 
            this.tab2CheckBox1.Location = new System.Drawing.Point(32, 24);
            this.tab2CheckBox1.Name = "tab2CheckBox1";
            this.tab2CheckBox1.Size = new System.Drawing.Size(176, 32);
            this.tab2CheckBox1.TabIndex = 0;
            this.tab2CheckBox1.Text = "checkBox1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tab3RadioButton2);
            this.tabPage3.Controls.Add(this.tab3RadioButton1);
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1418, 1101);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "باستا";
            // 
            // tab3RadioButton1
            // 
            this.tab3RadioButton1.Location = new System.Drawing.Point(40, 65);
            this.tab3RadioButton1.Name = "tab3RadioButton1";
            this.tab3RadioButton1.Size = new System.Drawing.Size(206, 88);
            this.tab3RadioButton1.TabIndex = 0;
            this.tab3RadioButton1.Text = "radioButton1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1143, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 86);
            this.button1.TabIndex = 1;
            this.button1.Text = "وجبات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(773, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 86);
            this.button2.TabIndex = 2;
            this.button2.Text = "بيتزا";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(451, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 86);
            this.button3.TabIndex = 3;
            this.button3.Text = "باستا";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(113, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 86);
            this.button4.TabIndex = 4;
            this.button4.Text = "اضافات";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(1515, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 1429);
            this.panel1.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Location = new System.Drawing.Point(214, 1166);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(712, 107);
            this.panel7.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 39);
            this.comboBox1.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(544, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 52);
            this.label3.TabIndex = 15;
            this.label3.Text = "الطيار";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(214, 1302);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(708, 118);
            this.panel6.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.YellowGreen;
            this.button5.Location = new System.Drawing.Point(499, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 91);
            this.button5.TabIndex = 7;
            this.button5.Text = "طباعه";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(194, 91);
            this.button6.TabIndex = 5;
            this.button6.Text = "مسح";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.textBox3);
            this.panel5.Location = new System.Drawing.Point(214, 976);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(708, 81);
            this.panel5.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "الاجمالى";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(25, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 38);
            this.textBox3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioButton3);
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Location = new System.Drawing.Point(214, 1063);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(708, 80);
            this.panel4.TabIndex = 11;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(67, 21);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(115, 36);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "دليفرى";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(526, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(134, 36);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "تيك اواى";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order,
            this.quantity,
            this.Column1,
            this.col4});
            this.dataGridView1.Location = new System.Drawing.Point(20, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1079, 919);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Order
            // 
            this.Order.HeaderText = "الصنف";
            this.Order.Name = "Order";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "الكميه";
            this.quantity.Name = "quantity";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "السعر";
            this.Column1.Name = "Column1";
            // 
            // col4
            // 
            this.col4.HeaderText = "ملاحظات";
            this.col4.Name = "col4";
            // 
            // Manually_generated_form
            // 
            this.ClientSize = new System.Drawing.Size(2757, 1453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Manually_generated_form";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void tab1Button1_Click(object sender, System.EventArgs e)
        {
            // Inserts the code that should run when the button is clicked.
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0; ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex=1; ;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.tabControl1.SelectedIndex = 2; ;
            this.tabControl1.SelectTab(2);

        }

        private void dataGridView1_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
}
