namespace ukazkaknih
{
    partial class FormStmívání
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
            this.lbl_stmivani = new System.Windows.Forms.Label();
            this.btn_autor = new System.Windows.Forms.Button();
            this.btnpocet = new System.Windows.Forms.Button();
            this.btn_obsahh = new System.Windows.Forms.Button();
            this.btn_hodno = new System.Windows.Forms.Button();
            this.btn_zpet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_stmivani
            // 
            this.lbl_stmivani.AutoSize = true;
            this.lbl_stmivani.Location = new System.Drawing.Point(193, 43);
            this.lbl_stmivani.Name = "lbl_stmivani";
            this.lbl_stmivani.Size = new System.Drawing.Size(53, 15);
            this.lbl_stmivani.TabIndex = 0;
            this.lbl_stmivani.Text = "Stmívání";
            // 
            // btn_autor
            // 
            this.btn_autor.Location = new System.Drawing.Point(183, 91);
            this.btn_autor.Name = "btn_autor";
            this.btn_autor.Size = new System.Drawing.Size(75, 23);
            this.btn_autor.TabIndex = 1;
            this.btn_autor.Text = "Autor";
            this.btn_autor.UseVisualStyleBackColor = true;
            this.btn_autor.Click += new System.EventHandler(this.btn_autor_Click);
            // 
            // btnpocet
            // 
            this.btnpocet.Location = new System.Drawing.Point(183, 142);
            this.btnpocet.Name = "btnpocet";
            this.btnpocet.Size = new System.Drawing.Size(75, 23);
            this.btnpocet.TabIndex = 2;
            this.btnpocet.Text = "Počet stran";
            this.btnpocet.UseVisualStyleBackColor = true;
            this.btnpocet.Click += new System.EventHandler(this.btnpocet_Click);
            // 
            // btn_obsahh
            // 
            this.btn_obsahh.Location = new System.Drawing.Point(183, 190);
            this.btn_obsahh.Name = "btn_obsahh";
            this.btn_obsahh.Size = new System.Drawing.Size(75, 23);
            this.btn_obsahh.TabIndex = 3;
            this.btn_obsahh.Text = "Obsah";
            this.btn_obsahh.UseVisualStyleBackColor = true;
            this.btn_obsahh.Click += new System.EventHandler(this.btn_obsahh_Click);
            // 
            // btn_hodno
            // 
            this.btn_hodno.Location = new System.Drawing.Point(183, 237);
            this.btn_hodno.Name = "btn_hodno";
            this.btn_hodno.Size = new System.Drawing.Size(75, 23);
            this.btn_hodno.TabIndex = 4;
            this.btn_hodno.Text = "Hodnocení";
            this.btn_hodno.UseVisualStyleBackColor = true;
            this.btn_hodno.Click += new System.EventHandler(this.btn_hodno_Click);
            // 
            // btn_zpet
            // 
            this.btn_zpet.Location = new System.Drawing.Point(3, 326);
            this.btn_zpet.Name = "btn_zpet";
            this.btn_zpet.Size = new System.Drawing.Size(75, 23);
            this.btn_zpet.TabIndex = 5;
            this.btn_zpet.Text = "Zpět";
            this.btn_zpet.UseVisualStyleBackColor = true;
            this.btn_zpet.Click += new System.EventHandler(this.btn_zpet_Click);
            // 
            // FormStmívání
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 352);
            this.Controls.Add(this.btn_zpet);
            this.Controls.Add(this.btn_hodno);
            this.Controls.Add(this.btn_obsahh);
            this.Controls.Add(this.btnpocet);
            this.Controls.Add(this.btn_autor);
            this.Controls.Add(this.lbl_stmivani);
            this.Name = "FormStmívání";
            this.Text = "FormStmívání";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_stmivani;
        private Button btn_autor;
        private Button btnpocet;
        private Button btn_obsahh;
        private Button btn_hodno;
        private Button btn_zpet;
    }
}