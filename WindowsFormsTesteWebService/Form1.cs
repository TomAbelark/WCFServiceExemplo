using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTesteWebService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicoSomar.ServiceClient soma = new ServicoSomar.ServiceClient();
            textBox3.Text = soma.Somar(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Fr2 = new Form2();
            Fr2.Show();
        }
    }
}
