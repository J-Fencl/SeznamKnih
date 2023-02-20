using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ukazkaknih
{
    public partial class FormSeznam : Form
    {
        public FormSeznam()
        {
            InitializeComponent();
        }

        private void btn_zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void btn_harry_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormHarry fharry = new FormHarry();
            fharry.Show();

        }

        private void btn_stmivani_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormStmívání fstmivani = new FormStmívání();
            fstmivani.Show();
        }

        private void btn_tanec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tanec_s_Draky ftanec = new Tanec_s_Draky();
            ftanec.Show();
        }
    }
}
