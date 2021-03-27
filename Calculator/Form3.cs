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
    public partial class Form3 : Form
    {
        List<string> gName = new List<string>();
        List<string> number = new List<string>();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            gName.Add("Narayan");
            gName.Add("Dhurmus");
            gName.Add("Magne budo");
            gName.Add("Jigree Bro");
            gName.Add("Pade Don");
            gName.Add("Paul Shah");
            gName.Add("Jibesh Singh");
            gName.Add("Bhuwan KC");
            gName.Add("Sharuk Khan");
            gName.Add("Anmol KC");


            number.Add("98918942384");
            number.Add("98293483248");
            number.Add("98294829384");
            number.Add("98234983943");
            number.Add("98983948393");
            number.Add("98938493444");
            number.Add("98394839484");
            number.Add("98493843948");
            number.Add("98495849584");
            number.Add("98394854958");
            var random = new Random();
            int nameIndex = random.Next(gName.Count);
            int phoneNumber = random.Next(number.Count);
            string name = Form1.name;
            string age = Form1.age;
            string r1 = Form1.r1;
            string r2 = Form1.r2;
            label1.Text = "बधाई छ  " + name;
            label2.Text = "तपाईंको उमेर हो " + age;
            label4.Text = "केटाको फोन नम्बर हो  " + number[phoneNumber];
            label3.Text = "तपाईं " + gName[nameIndex] + "संग DATE गर्न सक्नुहुन्छ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
