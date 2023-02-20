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
    public partial class Tanec_s_Draky : Form
    {
        Knihy TanecSDraky = new Knihy("Tanec s draky", "G.R.R. Martin", "1104", "Sedm království se zmítá v agónii intrik a zrady. Také proto se pozornost vypravěče upírá jiným směrem – na východ. Za mořem povstává z popela a prachu mocná vládkyně – Daenerys z rodu Targaryenů, matka draků, kteří stále rostou a sílí. Daenerys se stává majákem, ke kterému míří i Tyrion Lannister. Ke slovu se dostává také pouštní království Dorne, na šachovnici se objevují nové figury, aby zaplnily místo těch dávno padlých. Na Zdi, kde se situace zhoršuje doslova každým okamžikem, se stává velitelem John Sníh. Na vrata buší Zdivočelí, kterým jsou v patách Jiní, ani všichni bratři ve zbrani nejsou z volby nadšeni. Zima je prakticky tady a velké finále před branami.", "Hodnocení podle Databáze knih 92%");
        public Tanec_s_Draky()
        {
            InitializeComponent();
        }

        private void btn_autor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TanecSDraky.autor);
        }

        private void btn_pocetstran_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TanecSDraky.pocetstranek);
        }

        private void btn_obsah_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TanecSDraky.obsah);
        }

        private void btn_hodnoceni_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TanecSDraky.hodnoceni);
        }

        private void btn_zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeznam fseznam = new FormSeznam();
            fseznam.Show();
        }
    }
}
