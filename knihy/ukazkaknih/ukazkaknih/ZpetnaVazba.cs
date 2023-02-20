using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ukazkaknih
{
    public partial class ZpetnaVazba : Form
    {
        public ZpetnaVazba()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText("zpetnavazba.txt"))
            {
                sw.WriteLine(textBox1.Text+Environment.NewLine);
            }
            textBox1.Clear();
            MessageBox.Show("Uloženo");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
