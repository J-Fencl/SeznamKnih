namespace ukazkaknih
{
    partial class FormSeznam
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
            this.btn_harry = new System.Windows.Forms.Button();
            this.btn_stmivani = new System.Windows.Forms.Button();
            this.btn_tanec = new System.Windows.Forms.Button();
            this.btn_zpet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_harry
            // 
            this.btn_harry.Location = new System.Drawing.Point(97, 63);
            this.btn_harry.Name = "btn_harry";
            this.btn_harry.Size = new System.Drawing.Size(239, 39);
            this.btn_harry.TabIndex = 0;
            this.btn_harry.Text = "Harry Potter a Kámen mudrců";
            this.btn_harry.UseVisualStyleBackColor = true;
            this.btn_harry.Click += new System.EventHandler(this.btn_harry_Click);
            // 
            // btn_stmivani
            // 
            this.btn_stmivani.Location = new System.Drawing.Point(97, 153);
            this.btn_stmivani.Name = "btn_stmivani";
            this.btn_stmivani.Size = new System.Drawing.Size(239, 39);
            this.btn_stmivani.TabIndex = 1;
            this.btn_stmivani.Text = "Stmívání";
            this.btn_stmivani.UseVisualStyleBackColor = true;
            this.btn_stmivani.Click += new System.EventHandler(this.btn_stmivani_Click);
            // 
            // btn_tanec
            // 
            this.btn_tanec.Location = new System.Drawing.Point(97, 245);
            this.btn_tanec.Name = "btn_tanec";
            this.btn_tanec.Size = new System.Drawing.Size(239, 39);
            this.btn_tanec.TabIndex = 2;
            this.btn_tanec.Text = "Tanec s draky";
            this.btn_tanec.UseVisualStyleBackColor = true;
            this.btn_tanec.Click += new System.EventHandler(this.btn_tanec_Click);
            // 
            // btn_zpet
            // 
            this.btn_zpet.Location = new System.Drawing.Point(2, 327);
            this.btn_zpet.Name = "btn_zpet";
            this.btn_zpet.Size = new System.Drawing.Size(75, 23);
            this.btn_zpet.TabIndex = 3;
            this.btn_zpet.Text = "Zpět";
            this.btn_zpet.UseVisualStyleBackColor = true;
            this.btn_zpet.Click += new System.EventHandler(this.btn_zpet_Click);
            // 
            // FormSeznam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 352);
            this.Controls.Add(this.btn_zpet);
            this.Controls.Add(this.btn_tanec);
            this.Controls.Add(this.btn_stmivani);
            this.Controls.Add(this.btn_harry);
            this.Name = "FormSeznam";
            this.Text = "FormSeznam";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_harry;
        private Button btn_stmivani;
        private Button btn_tanec;
        private Button btn_zpet;
    }
}