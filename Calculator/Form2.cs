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
    public partial class Form2 : Form
    {

        List<string> gName = new List<string>();
        List<string> number = new List<string>();
        
        public Form2()
        {
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gName.Add("आइस्ता");
            gName.Add("आकर्ती");
            gName.Add("आंचल");
            gName.Add("आरती");
            gName.Add("आशा)");
            gName.Add("आश्रिया");
            gName.Add("आयुषा");
            gName.Add("आयुष्मा");
            gName.Add("अभिलाषा");
            gName.Add("अदिति");


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
            label2.Text = "बधाई छ  " + name;
            label1.Text = "तपाईंको उमेर हो " + age;
            label3.Text = "तपाईं " + gName[nameIndex] + "संग DATE गर्न सक्नुहुन्छ";
            label4.Text = " केटीको फोन नम्बर हो " + number[phoneNumber];
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();

        }
    }
}
