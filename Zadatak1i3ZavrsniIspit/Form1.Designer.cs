namespace $safeprojectname$
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
            this.components = new System.ComponentModel.Container();
            this.lbKrave = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnIzmjeni = new System.Windows.Forms.Button();
            this.lblIspis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKrave
            // 
            this.lbKrave.FormattingEnabled = true;
            this.lbKrave.Location = new System.Drawing.Point(12, 12);
            this.lbKrave.Name = "lbKrave";
            this.lbKrave.Size = new System.Drawing.Size(287, 173);
            this.lbKrave.TabIndex = 0;
            this.lbKrave.SelectedIndexChanged += new System.EventHandler(this.lbKrave_SelectedIndexChanged);
            // 
            // btnIzmjeni
            // 
            this.btnIzmjeni.Location = new System.Drawing.Point(12, 191);
            this.btnIzmjeni.Name = "btnIzmjeni";
            this.btnIzmjeni.Size = new System.Drawing.Size(287, 31);
            this.btnIzmjeni.TabIndex = 1;
            this.btnIzmjeni.Text = "Promijeni podatke krave";
            this.btnIzmjeni.UseVisualStyleBackColor = true;
            this.btnIzmjeni.Click += new System.EventHandler(this.btnIzmjeni_Click);
            // 
            // lblIspis
            // 
            this.lblIspis.AutoSize = true;
            this.lblIspis.Location = new System.Drawing.Point(134, 261);
            this.lblIspis.Name = "lblIspis";
            this.lblIspis.Size = new System.Drawing.Size(35, 13);
            this.lblIspis.TabIndex = 2;
            this.lblIspis.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 316);
            this.Controls.Add(this.lblIspis);
            this.Controls.Add(this.btnIzmjeni);
            this.Controls.Add(this.lbKrave);
            this.Name = "Form1";
            this.Text = "Krave";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbKrave;
        private System.Windows.Forms.Button btnIzmjeni;
        private System.Windows.Forms.Label lblIspis;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

