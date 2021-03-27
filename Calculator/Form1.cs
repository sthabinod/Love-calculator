using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public static string name = "";
        public static string age = "";
        public static string r1 = "";
        public static string r2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="" && txtAge.Text=="")
            {
                MessageBox.Show("कृपया तपाईंको नाम र उमेर प्रविष्ट गर्नुहोस्!");
            }
            else
            {
                if(int.Parse(txtAge.Text )>= 16 && int.Parse( txtAge.Text )<=50)
                {
                    name = txtName.Text;
                    age = txtAge.Text;
                    r1 = radioButton1.Text;
                    r2 = radioButton2.Text;
                    if (radioButton1.Checked)
                    {
                        Form2 form2 = new Form2();
                        this.Hide();
                        form2.Show();
                    }
                    else if (radioButton2.Checked)
                    {
                        Form3 form3 = new Form3();
                        this.Hide();
                        form3.Show();

                    }
                }
                else
                {
                    MessageBox.Show("उमेर योग्य छैन");
                }
                
            }

        }
    }
}
