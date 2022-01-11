namespace RichTextBox
{
    partial class Form1
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
            this.buttonCitaj = new System.Windows.Forms.Button();
            this.buttonBrisi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonSpremi = new System.Windows.Forms.Button();
            this.buttonMapa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCitaj
            // 
            this.buttonCitaj.Location = new System.Drawing.Point(43, 29);
            this.buttonCitaj.Name = "buttonCitaj";
            this.buttonCitaj.Size = new System.Drawing.Size(99, 52);
            this.buttonCitaj.TabIndex = 0;
            this.buttonCitaj.Text = "Učitaj";
            this.buttonCitaj.UseVisualStyleBackColor = true;
            this.buttonCitaj.Click += new System.EventHandler(this.buttonCitaj_Click);
            // 
            // buttonBrisi
            // 
            this.buttonBrisi.Location = new System.Drawing.Point(174, 29);
            this.buttonBrisi.Name = "buttonBrisi";
            this.buttonBrisi.Size = new System.Drawing.Size(108, 53);
            this.buttonBrisi.TabIndex = 1;
            this.buttonBrisi.Text = "&Briši";
            this.buttonBrisi.UseVisualStyleBackColor = true;
            this.buttonBrisi.Click += new System.EventHandler(this.buttonBrisi_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(43, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(239, 143);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // buttonSpremi
            // 
            this.buttonSpremi.Location = new System.Drawing.Point(43, 236);
            this.buttonSpremi.Name = "buttonSpremi";
            this.buttonSpremi.Size = new System.Drawing.Size(162, 53);
            this.buttonSpremi.TabIndex = 3;
            this.buttonSpremi.Text = "Spremi";
            this.buttonSpremi.UseVisualStyleBackColor = true;
            this.buttonSpremi.Click += new System.EventHandler(this.buttonSpremi_Click);
            // 
            // buttonMapa
            // 
            this.buttonMapa.Location = new System.Drawing.Point(212, 237);
            this.buttonMapa.Name = "buttonMapa";
            this.buttonMapa.Size = new System.Drawing.Size(70, 52);
            this.buttonMapa.TabIndex = 4;
            this.buttonMapa.Text = "&Mapa";
            this.buttonMapa.UseVisualStyleBackColor = true;
            this.buttonMapa.Click += new System.EventHandler(this.buttonMapa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 303);
            this.Controls.Add(this.buttonMapa);
            this.Controls.Add(this.buttonSpremi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonBrisi);
            this.Controls.Add(this.buttonCitaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCitaj;
        private System.Windows.Forms.Button buttonBrisi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonSpremi;
        private System.Windows.Forms.Button buttonMapa;
    }
}

