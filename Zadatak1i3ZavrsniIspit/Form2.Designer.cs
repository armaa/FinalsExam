namespace $safeprojectname$
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtVetBroj = new System.Windows.Forms.TextBox();
            this.dateRodjen = new System.Windows.Forms.DateTimePicker();
            this.dateDolazak = new System.Windows.Forms.DateTimePicker();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbPasmina = new System.Windows.Forms.ComboBox();
            this.numBrojTeladi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numBrojTeladi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pasmina:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(118, 6);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(152, 20);
            this.txtIme.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Datum rodjenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Veterinarski broj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Datum dolaska:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Broj teladi:";
            // 
            // txtVetBroj
            // 
            this.txtVetBroj.Location = new System.Drawing.Point(118, 110);
            this.txtVetBroj.Name = "txtVetBroj";
            this.txtVetBroj.Size = new System.Drawing.Size(152, 20);
            this.txtVetBroj.TabIndex = 9;
            // 
            // dateRodjen
            // 
            this.dateRodjen.Location = new System.Drawing.Point(118, 74);
            this.dateRodjen.Name = "dateRodjen";
            this.dateRodjen.Size = new System.Drawing.Size(152, 20);
            this.dateRodjen.TabIndex = 12;
            // 
            // dateDolazak
            // 
            this.dateDolazak.Location = new System.Drawing.Point(118, 145);
            this.dateDolazak.Name = "dateDolazak";
            this.dateDolazak.Size = new System.Drawing.Size(152, 20);
            this.dateDolazak.TabIndex = 13;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 222);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(107, 35);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Izmijeni";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(162, 222);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 35);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbPasmina
            // 
            this.cbPasmina.FormattingEnabled = true;
            this.cbPasmina.Location = new System.Drawing.Point(118, 39);
            this.cbPasmina.Name = "cbPasmina";
            this.cbPasmina.Size = new System.Drawing.Size(152, 21);
            this.cbPasmina.TabIndex = 16;
            // 
            // numBrojTeladi
            // 
            this.numBrojTeladi.Location = new System.Drawing.Point(118, 182);
            this.numBrojTeladi.Name = "numBrojTeladi";
            this.numBrojTeladi.Size = new System.Drawing.Size(152, 20);
            this.numBrojTeladi.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 270);
            this.Controls.Add(this.numBrojTeladi);
            this.Controls.Add(this.cbPasmina);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dateDolazak);
            this.Controls.Add(this.dateRodjen);
            this.Controls.Add(this.txtVetBroj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numBrojTeladi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtVetBroj;
        private System.Windows.Forms.DateTimePicker dateRodjen;
        private System.Windows.Forms.DateTimePicker dateDolazak;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbPasmina;
        private System.Windows.Forms.NumericUpDown numBrojTeladi;
    }
}