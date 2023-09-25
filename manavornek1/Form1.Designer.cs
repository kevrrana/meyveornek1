namespace manavornek1
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
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.txtMeyveler = new System.Windows.Forms.TextBox();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnSeçileniSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSepeteEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSepeteEkle.Location = new System.Drawing.Point(22, 62);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(184, 40);
            this.btnSepeteEkle.TabIndex = 0;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = false;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 24;
            this.lstSepet.Location = new System.Drawing.Point(240, 27);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(178, 220);
            this.lstSepet.TabIndex = 2;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
            // 
            // txtMeyveler
            // 
            this.txtMeyveler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMeyveler.Location = new System.Drawing.Point(22, 27);
            this.txtMeyveler.Name = "txtMeyveler";
            this.txtMeyveler.Size = new System.Drawing.Size(184, 29);
            this.txtMeyveler.TabIndex = 3;
            this.txtMeyveler.Text = " ";
            this.txtMeyveler.TextChanged += new System.EventHandler(this.txtMeyveler_TextChanged);
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHepsiniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.Location = new System.Drawing.Point(22, 150);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(184, 36);
            this.btnHepsiniSil.TabIndex = 5;
            this.btnHepsiniSil.Text = "Hepsini Sil";
            this.btnHepsiniSil.UseVisualStyleBackColor = false;
            this.btnHepsiniSil.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeçileniSil
            // 
            this.btnSeçileniSil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSeçileniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeçileniSil.Location = new System.Drawing.Point(22, 108);
            this.btnSeçileniSil.Name = "btnSeçileniSil";
            this.btnSeçileniSil.Size = new System.Drawing.Size(184, 36);
            this.btnSeçileniSil.TabIndex = 6;
            this.btnSeçileniSil.Text = "Seçileni Sil";
            this.btnSeçileniSil.UseVisualStyleBackColor = false;
            this.btnSeçileniSil.Click += new System.EventHandler(this.btnSeçileniSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 287);
            this.Controls.Add(this.btnSeçileniSil);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.txtMeyveler);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnSepeteEkle);
            this.Name = "Form1";
            this.Text = " Alışveriş Listesi(Me)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.TextBox txtMeyveler;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnSeçileniSil;
    }
}

