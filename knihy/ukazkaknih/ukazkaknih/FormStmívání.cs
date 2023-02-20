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
    public partial class FormStmívání : Form
    {
        Knihy Stmivani = new Knihy("Stmívání", "Stephenie Meyer", "408", "První kniha série Stmívání.Isabella Swan se stěhuje do Forks, městečka ve státě Washington, kde neustále prší. Zdá se jí, že na světě neexistuje nudnější a beznadějnější místo – až dokud nepotká tajuplného a přitažlivého Edwarda Cullena, který doslova obrátí její život vzhůru nohama. Do Isabellina příjezdu Edward úspěšně tajil před obyvateli městečka svou upírskou osobnost. Ale nikdo není v bezpečí, zvláště Isabella, člověk, který je Edwardovi nejdražší. Oba mladí lidé jsou k sobě vázáni silným citovým poutem. Zvítězí milostný cit, nebo hrůzné temné pudy?", "Hodnocení podle Databáze knih 77%");
        public FormStmívání()
        {
            InitializeComponent();
        }

        private void btn_autor_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Stmivani.autor);
        }

        private void btnpocet_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Stmivani.pocetstranek);
        }

        private void btn_obsahh_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Stmivani.obsah);
        }

        private void btn_hodno_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Stmivani.hodnoceni);
        }

        private void btn_zpet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeznam fseznam = new FormSeznam();
            fseznam.Show();
        }
    }
}
