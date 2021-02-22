namespace Kolekcije
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
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnRazvrstaj = new System.Windows.Forms.Button();
            this.btnIspis = new System.Windows.Forms.Button();
            this.txtPodatak1 = new System.Windows.Forms.TextBox();
            this.txtPodatak2 = new System.Windows.Forms.TextBox();
            this.txtPodatak3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtxtIspis = new System.Windows.Forms.RichTextBox();
            this.cmbPodatak4 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUnos.Location = new System.Drawing.Point(157, 15);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(200, 185);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "Unesi";
            this.btnUnos.UseVisualStyleBackColor = false;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnRazvrstaj
            // 
            this.btnRazvrstaj.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRazvrstaj.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.btnRazvrstaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRazvrstaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRazvrstaj.Location = new System.Drawing.Point(365, 15);
            this.btnRazvrstaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnRazvrstaj.Name = "btnRazvrstaj";
            this.btnRazvrstaj.Size = new System.Drawing.Size(200, 185);
            this.btnRazvrstaj.TabIndex = 6;
            this.btnRazvrstaj.Text = "Obradi";
            this.btnRazvrstaj.UseVisualStyleBackColor = false;
            this.btnRazvrstaj.Click += new System.EventHandler(this.btnRazvrstaj_Click);
            // 
            // btnIspis
            // 
            this.btnIspis.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIspis.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.btnIspis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIspis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIspis.Location = new System.Drawing.Point(576, 15);
            this.btnIspis.Margin = new System.Windows.Forms.Padding(4);
            this.btnIspis.Name = "btnIspis";
            this.btnIspis.Size = new System.Drawing.Size(200, 185);
            this.btnIspis.TabIndex = 7;
            this.btnIspis.Text = "Ispiši";
            this.btnIspis.UseVisualStyleBackColor = false;
            this.btnIspis.Click += new System.EventHandler(this.btnIspis_Click);
            // 
            // txtPodatak1
            // 
            this.txtPodatak1.Location = new System.Drawing.Point(16, 31);
            this.txtPodatak1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPodatak1.Name = "txtPodatak1";
            this.txtPodatak1.Size = new System.Drawing.Size(132, 22);
            this.txtPodatak1.TabIndex = 0;
            // 
            // txtPodatak2
            // 
            this.txtPodatak2.Location = new System.Drawing.Point(16, 79);
            this.txtPodatak2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPodatak2.Name = "txtPodatak2";
            this.txtPodatak2.Size = new System.Drawing.Size(132, 22);
            this.txtPodatak2.TabIndex = 1;
            // 
            // txtPodatak3
            // 
            this.txtPodatak3.Location = new System.Drawing.Point(16, 127);
            this.txtPodatak3.Margin = new System.Windows.Forms.Padding(4);
            this.txtPodatak3.Name = "txtPodatak3";
            this.txtPodatak3.Size = new System.Drawing.Size(132, 22);
            this.txtPodatak3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Podatak 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Podatak 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Podatak 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Podatak 4";
            // 
            // rtxtIspis
            // 
            this.rtxtIspis.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rtxtIspis.Location = new System.Drawing.Point(16, 207);
            this.rtxtIspis.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtIspis.Name = "rtxtIspis";
            this.rtxtIspis.ReadOnly = true;
            this.rtxtIspis.Size = new System.Drawing.Size(759, 376);
            this.rtxtIspis.TabIndex = 11;
            this.rtxtIspis.TabStop = false;
            this.rtxtIspis.Text = "";
            // 
            // cmbPodatak4
            // 
            this.cmbPodatak4.FormattingEnabled = true;
            this.cmbPodatak4.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cmbPodatak4.Location = new System.Drawing.Point(16, 175);
            this.cmbPodatak4.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPodatak4.Name = "cmbPodatak4";
            this.cmbPodatak4.Size = new System.Drawing.Size(132, 24);
            this.cmbPodatak4.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 598);
            this.Controls.Add(this.cmbPodatak4);
            this.Controls.Add(this.rtxtIspis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPodatak3);
            this.Controls.Add(this.txtPodatak2);
            this.Controls.Add(this.txtPodatak1);
            this.Controls.Add(this.btnIspis);
            this.Controls.Add(this.btnRazvrstaj);
            this.Controls.Add(this.btnUnos);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "All app";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnRazvrstaj;
        private System.Windows.Forms.Button btnIspis;
        private System.Windows.Forms.TextBox txtPodatak1;
        private System.Windows.Forms.TextBox txtPodatak2;
        private System.Windows.Forms.TextBox txtPodatak3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtxtIspis;
        private System.Windows.Forms.ComboBox cmbPodatak4;
    }
}

