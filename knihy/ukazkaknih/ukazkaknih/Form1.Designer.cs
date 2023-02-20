namespace ukazkaknih
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_seznam = new System.Windows.Forms.Button();
            this.btn_zpetna = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_seznam
            // 
            this.btn_seznam.Location = new System.Drawing.Point(149, 135);
            this.btn_seznam.Name = "btn_seznam";
            this.btn_seznam.Size = new System.Drawing.Size(146, 41);
            this.btn_seznam.TabIndex = 0;
            this.btn_seznam.Text = "Seznam knih";
            this.btn_seznam.UseVisualStyleBackColor = true;
            this.btn_seznam.Click += new System.EventHandler(this.btn_seznam_Click);
            // 
            // btn_zpetna
            // 
            this.btn_zpetna.Location = new System.Drawing.Point(137, 249);
            this.btn_zpetna.Name = "btn_zpetna";
            this.btn_zpetna.Size = new System.Drawing.Size(158, 23);
            this.btn_zpetna.TabIndex = 1;
            this.btn_zpetna.Text = "Napsat zpětnou vazbu";
            this.btn_zpetna.UseVisualStyleBackColor = true;
            this.btn_zpetna.Click += new System.EventHandler(this.btn_zpetna_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(175, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ukázat zpětné vazby uživatelů";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 351);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_zpetna);
            this.Controls.Add(this.btn_seznam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_seznam;
        private Button btn_zpetna;
        private Button button2;
    }
}