using System.Xml;

namespace modul3_1302210021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int plus, samadengan, hasil, kali, nomor;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label1.Text = label1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }



        private void button13_Click(object sender, EventArgs e)
        {
            kali = int.Parse(label1.Text);
            label1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            plus = int.Parse(label1.Text);
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            samadengan = int.Parse(label1.Text);
            hasil = plus + samadengan;
            label1.Text = hasil.ToString();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            samadengan = int.Parse(label1.Text);
            hasil = kali * samadengan;
            label1.Text = hasil.ToString();
        }

    }
}