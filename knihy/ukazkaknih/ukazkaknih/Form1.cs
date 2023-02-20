namespace ukazkaknih
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_seznam_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSeznam formSeznam= new FormSeznam();
            formSeznam.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText("zpetnavazba.txt");
            MessageBox.Show(text);
        }

        private void btn_zpetna_Click(object sender, EventArgs e)
        {
            this.Hide();
            ZpetnaVazba fzpetna = new ZpetnaVazba();
            fzpetna.Show();
        }
    }
}