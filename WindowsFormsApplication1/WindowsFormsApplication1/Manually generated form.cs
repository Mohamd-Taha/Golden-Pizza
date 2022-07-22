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
        private System.Windows.Forms.Button tab1Button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControl1;

        public Manually_generated_form()
        {
            // This call is required for Windows Form Designer support.
            InitializeComponent();
        }

        // This method is required for Designer support.
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tab1Label1 = new System.Windows.Forms.Label();
            this.tab1Button1 = new System.Windows.Forms.Button();
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
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tab1Label1);
            this.tabPage1.Controls.Add(this.tab1Button1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1335, 897);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // tab1Label1
            // 
            this.tab1Label1.Location = new System.Drawing.Point(16, 24);
            this.tab1Label1.Name = "tab1Label1";
            this.tab1Label1.Size = new System.Drawing.Size(224, 96);
            this.tab1Label1.TabIndex = 1;
            this.tab1Label1.Text = "label1";
            // 
            // tab1Button1
            // 
            this.tab1Button1.Location = new System.Drawing.Point(88, 144);
            this.tab1Button1.Name = "tab1Button1";
            this.tab1Button1.Size = new System.Drawing.Size(251, 157);
            this.tab1Button1.TabIndex = 0;
            this.tab1Button1.Text = "بيتزا";
            this.tab1Button1.Click += new System.EventHandler(this.tab1Button1_Click);
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
            this.tabControl1.Location = new System.Drawing.Point(40, 131);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1355, 955);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tab2CheckBox3);
            this.tabPage2.Controls.Add(this.tab2CheckBox2);
            this.tabPage2.Controls.Add(this.tab2CheckBox1);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1335, 897);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
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
            this.tabPage3.Size = new System.Drawing.Size(1335, 897);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
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
            this.button1.Location = new System.Drawing.Point(1358, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(468, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "وجبات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(753, 39);
            this.button2.Name = "سندوتشات";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(468, 50);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Manually_generated_form
            // 
            this.ClientSize = new System.Drawing.Size(1909, 1291);
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
    }
}
