namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(32, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(841, 770);
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 865);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 38);
            this.textBox3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 857);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "الاجمالى";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Location = new System.Drawing.Point(1795, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 1121);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.YellowGreen;
            this.button3.Location = new System.Drawing.Point(615, 974);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 91);
            this.button3.TabIndex = 7;
            this.button3.Text = "طباعه";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 974);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 91);
            this.button1.TabIndex = 5;
            this.button1.Text = "مسح";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(25, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1733, 196);
            this.panel2.TabIndex = 6;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(732, 80);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(222, 66);
            this.button10.TabIndex = 10;
            this.button10.Text = "وجبات";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(437, 80);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(222, 66);
            this.button9.TabIndex = 9;
            this.button9.Text = "اضافات";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1052, 80);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(222, 66);
            this.button4.TabIndex = 8;
            this.button4.Text = "باستا";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1466, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(222, 66);
            this.button2.TabIndex = 7;
            this.button2.Text = "بيتزا";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1544, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 55);
            this.label2.TabIndex = 7;
            this.label2.Text = " المنتجات";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button17);
            this.panel3.Controls.Add(this.button18);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Location = new System.Drawing.Point(25, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1743, 868);
            this.panel3.TabIndex = 7;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(869, 604);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(393, 145);
            this.button15.TabIndex = 11;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(437, 604);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(393, 145);
            this.button16.TabIndex = 10;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(25, 604);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(393, 145);
            this.button17.TabIndex = 9;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(1323, 604);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(393, 145);
            this.button18.TabIndex = 8;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(869, 326);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(393, 145);
            this.button11.TabIndex = 7;
            this.button11.Text = "button11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(437, 326);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(393, 145);
            this.button12.TabIndex = 6;
            this.button12.Text = "button12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(25, 326);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(393, 145);
            this.button13.TabIndex = 5;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(1323, 326);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(393, 145);
            this.button14.TabIndex = 4;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(869, 68);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(393, 145);
            this.button8.TabIndex = 3;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(437, 68);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(393, 145);
            this.button7.TabIndex = 2;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(25, 68);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(393, 145);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1323, 68);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(393, 145);
            this.button5.TabIndex = 0;
            this.button5.Text = "باستا جمبرى(15)";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(25, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1771, 1227);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button23);
            this.tabPage1.Controls.Add(this.button22);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1751, 1169);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1751, 1169);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(1098, 20);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(230, 116);
            this.button19.TabIndex = 0;
            this.button19.Text = "بيتزا فراخ ";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(823, 20);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(230, 116);
            this.button20.TabIndex = 1;
            this.button20.Text = "v";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(562, 20);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(230, 116);
            this.button21.TabIndex = 2;
            this.button21.Text = "v";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(298, 20);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(230, 116);
            this.button22.TabIndex = 3;
            this.button22.Text = "v";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(40, 20);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(230, 116);
            this.button23.TabIndex = 4;
            this.button23.Text = "v";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(10, 48);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1751, 1169);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1627, 1260);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(215, 36);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(1364, 1260);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(215, 36);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2713, 1522);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

