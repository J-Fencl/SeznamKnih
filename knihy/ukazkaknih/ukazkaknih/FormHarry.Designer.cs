namespace ukazkaknih
{
    partial class FormHarry
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
            this.lbl_jmenoharry = new System.Windows.Forms.Label();
            this.btn_autor = new System.Windows.Forms.Button();
            this.btn_pocetstran = new System.Windows.Forms.Button();
            this.btn_obsah = new System.Windows.Forms.Button();
            this.btn_hodnocení = new System.Windows.Forms.Button();
            this.btn_zpet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_jmenoharry
            // 
            this.lbl_jmenoharry.AutoSize = true;
            this.lbl_jmenoharry.Location = new System.Drawing.Point(137, 45);
            this.lbl_jmenoharry.Name = "lbl_jmenoharry";
            this.lbl_jmenoharry.Size = new System.Drawing.Size(165, 15);
            this.lbl_jmenoharry.TabIndex = 0;
            this.lbl_jmenoharry.Text = "Harry Potter a Kámen mudrců";
            this.lbl_jmenoharry.Click += new System.EventHandler(this.lbl_jmenoharry_Click);
            // 
            // btn_autor
            // 
            this.btn_autor.Location = new System.Drawing.Point(180, 89);
            this.btn_autor.Name = "btn_autor";
            this.btn_autor.Size = new System.Drawing.Size(75, 23);
            this.btn_autor.TabIndex = 1;
            this.btn_autor.Text = "Autor";
            this.btn_autor.UseVisualStyleBackColor = true;
            this.btn_autor.Click += new System.EventHandler(this.btn_autor_Click);
            // 
            // btn_pocetstran
            // 
            this.btn_pocetstran.Location = new System.Drawing.Point(180, 135);
            this.btn_pocetstran.Name = "btn_pocetstran";
            this.btn_pocetstran.Size = new System.Drawing.Size(75, 23);
            this.btn_pocetstran.TabIndex = 2;
            this.btn_pocetstran.Text = "Počet stran";
            this.btn_pocetstran.UseVisualStyleBackColor = true;
            this.btn_pocetstran.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_obsah
            // 
            this.btn_obsah.Location = new System.Drawing.Point(180, 183);
            this.btn_obsah.Name = "btn_obsah";
            this.btn_obsah.Size = new System.Drawing.Size(75, 23);
            this.btn_obsah.TabIndex = 3;
            this.btn_obsah.Text = "Obsah";
            this.btn_obsah.UseVisualStyleBackColor = true;
            this.btn_obsah.Click += new System.EventHandler(this.btn_obsah_Click);
            // 
            // btn_hodnocení
            // 
            this.btn_hodnocení.Location = new System.Drawing.Point(180, 228);
            this.btn_hodnocení.Name = "btn_hodnocení";
            this.btn_hodnocení.Size = new System.Drawing.Size(75, 23);
            this.btn_hodnocení.TabIndex = 4;
            this.btn_hodnocení.Text = "Hodnocení";
            this.btn_hodnocení.UseVisualStyleBackColor = true;
            this.btn_hodnocení.Click += new System.EventHandler(this.btn_hodnocení_Click);
            // 
            // btn_zpet
            // 
            this.btn_zpet.Location = new System.Drawing.Point(8, 325);
            this.btn_zpet.Name = "btn_zpet";
            this.btn_zpet.Size = new System.Drawing.Size(75, 23);
            this.btn_zpet.TabIndex = 5;
            this.btn_zpet.Text = "Zpět";
            this.btn_zpet.UseVisualStyleBackColor = true;
            this.btn_zpet.Click += new System.EventHandler(this.btn_zpet_Click);
            // 
            // FormHarry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 351);
            this.Controls.Add(this.btn_zpet);
            this.Controls.Add(this.btn_hodnocení);
            this.Controls.Add(this.btn_obsah);
            this.Controls.Add(this.btn_pocetstran);
            this.Controls.Add(this.btn_autor);
            this.Controls.Add(this.lbl_jmenoharry);
            this.Name = "FormHarry";
            this.Text = "FormHarry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_jmenoharry;
        private Button btn_autor;
        private Button btn_pocetstran;
        private Button btn_obsah;
        private Button btn_hodnocení;
        private Button btn_zpet;
    }
}