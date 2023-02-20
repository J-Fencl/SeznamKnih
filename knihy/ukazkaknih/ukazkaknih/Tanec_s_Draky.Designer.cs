namespace ukazkaknih
{
    partial class Tanec_s_Draky
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_autor = new System.Windows.Forms.Button();
            this.btn_pocetstran = new System.Windows.Forms.Button();
            this.btn_obsah = new System.Windows.Forms.Button();
            this.btn_hodnoceni = new System.Windows.Forms.Button();
            this.btn_zpet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tanec s draky";
            // 
            // btn_autor
            // 
            this.btn_autor.Location = new System.Drawing.Point(178, 96);
            this.btn_autor.Name = "btn_autor";
            this.btn_autor.Size = new System.Drawing.Size(75, 23);
            this.btn_autor.TabIndex = 1;
            this.btn_autor.Text = "Autor";
            this.btn_autor.UseVisualStyleBackColor = true;
            this.btn_autor.Click += new System.EventHandler(this.btn_autor_Click);
            // 
            // btn_pocetstran
            // 
            this.btn_pocetstran.Location = new System.Drawing.Point(178, 148);
            this.btn_pocetstran.Name = "btn_pocetstran";
            this.btn_pocetstran.Size = new System.Drawing.Size(75, 23);
            this.btn_pocetstran.TabIndex = 2;
            this.btn_pocetstran.Text = "Počet stran";
            this.btn_pocetstran.UseVisualStyleBackColor = true;
            this.btn_pocetstran.Click += new System.EventHandler(this.btn_pocetstran_Click);
            // 
            // btn_obsah
            // 
            this.btn_obsah.Location = new System.Drawing.Point(178, 198);
            this.btn_obsah.Name = "btn_obsah";
            this.btn_obsah.Size = new System.Drawing.Size(75, 23);
            this.btn_obsah.TabIndex = 3;
            this.btn_obsah.Text = "Obsah";
            this.btn_obsah.UseVisualStyleBackColor = true;
            this.btn_obsah.Click += new System.EventHandler(this.btn_obsah_Click);
            // 
            // btn_hodnoceni
            // 
            this.btn_hodnoceni.Location = new System.Drawing.Point(178, 245);
            this.btn_hodnoceni.Name = "btn_hodnoceni";
            this.btn_hodnoceni.Size = new System.Drawing.Size(75, 23);
            this.btn_hodnoceni.TabIndex = 4;
            this.btn_hodnoceni.Text = "Hodnocení";
            this.btn_hodnoceni.UseVisualStyleBackColor = true;
            this.btn_hodnoceni.Click += new System.EventHandler(this.btn_hodnoceni_Click);
            // 
            // btn_zpet
            // 
            this.btn_zpet.Location = new System.Drawing.Point(2, 325);
            this.btn_zpet.Name = "btn_zpet";
            this.btn_zpet.Size = new System.Drawing.Size(75, 23);
            this.btn_zpet.TabIndex = 5;
            this.btn_zpet.Text = "Zpět";
            this.btn_zpet.UseVisualStyleBackColor = true;
            this.btn_zpet.Click += new System.EventHandler(this.btn_zpet_Click);
            // 
            // Tanec_s_Draky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 350);
            this.Controls.Add(this.btn_zpet);
            this.Controls.Add(this.btn_hodnoceni);
            this.Controls.Add(this.btn_obsah);
            this.Controls.Add(this.btn_pocetstran);
            this.Controls.Add(this.btn_autor);
            this.Controls.Add(this.label1);
            this.Name = "Tanec_s_Draky";
            this.Text = "Tanec_s_Draky";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_autor;
        private Button btn_pocetstran;
        private Button btn_obsah;
        private Button btn_hodnoceni;
        private Button btn_zpet;
    }
}