using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Reflection.Metadata;

namespace Kassa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        decimal tot = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"
                kod: 101| Kurasan
                kod: 102| sular
                kod: 103| Çörək
                ");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string[] code = { "101", "102", "103" };
            string[] name = { "Kurasan", "sular", "Çörək" };
            decimal[] price = { 0.75M, 2.50M, 0.50M };

            if (textBox1.Text == code[0])
            {
                listBox1.Items.Add($"Kod:{code[0]}  |  Ad:{name[0]}  |  price:{price[0]} azn");
                tot = tot + price[0];
            }
            else if (textBox1.Text == code[1])
            {
                listBox1.Items.Add($"Kod:{code[1]}  |  Ad:{name[1]}  |  price:{price[1]} azn");
                tot = tot + price[1];
            }
            else if (textBox1.Text == code[2])
            {
                listBox1.Items.Add($"Kod:{code[2]}  |  Ad:{name[2]}  |  price:{price[2]}  azn");
                tot = tot + price[2];
            }
            total.Text = tot.ToString() + " " + "azn";


            decimal edv = tot / 100;
            decimal percent = edv * 18;

            QRCodeEncoder enc=new QRCodeEncoder();
            pictureBox1.Image = enc.Encode(percent.ToString());
                      
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox2.Text += btn.Text;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void btnhesablama_Click(object sender, EventArgs e)
        {
            decimal py=Convert.ToDecimal(textBox2.Text);
            if (py < tot)
            {
                error.Visible = true;
            }
            else
            {
                decimal ret = py - tot;
                paid.Text = py.ToString() + " " + "azn";
                returned.Text = ret.ToString() + " " + "azn";

            }
            
        }
    }
}
