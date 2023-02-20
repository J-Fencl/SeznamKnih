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
    public partial class FormHarry : Form
    {
        Knihy HarryKamen = new Knihy("Harry Potter a Kámen mudrců", "J.K.Rowling", "288", "Harry Potter si myslí, že je obyčejný kluk. Když byl ještě malý, zemřeli mu rodiče a on zná jen těžký život u strýce, tety a jejich tlustého a rozmazleného synka Dudleyho. Vše se ale změní ve chvíli, kdy mu poštovní sova přinese záhadný dopis - pozvánku ke studiu na Škole čar a kouzel v Bradavicích, a obr Hagrid mu prozradí, že je kouzelník! Harry neváhá ani vteřinu a odjíždí do Bradavic, kde potká své nejlepší kamarády - Rona Weasleyho a Hermionu Grangerovou, naučí se ovládat své kouzelnické schopnosti, stane se členem školního týmu famfrpálu - populárního kouzelnického sportu na košťatech, a především svede bitvu s Voldemortem, Pánem zla.", "Hodnocení podle Databáze Knih 93%");
        public FormHarry()
        {
            InitializeComponent();
        }

        private void lbl_jmenoharry_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HarryKamen.pocetstranek);
        }

        private void btn_autor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HarryKamen.autor);
        }

        private void btn_obsah_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HarryKamen.obsah);
        }

        private void btn_hodnocení_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HarryKamen.hodnoceni);
        }

        private void btn_zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeznam fseznam = new FormSeznam();
            fseznam.Show();
        }
    }
}
