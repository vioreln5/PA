namespace Aplicatie_Prezentare
{
    partial class frmAplicatiaLuViorel
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
            this.panouContinut = new System.Windows.Forms.Panel();
            this.btnCiocCioc = new System.Windows.Forms.Button();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.panouContinut.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panouContinut
            // 
            this.panouContinut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panouContinut.Controls.Add(this.btnCiocCioc);
            this.panouContinut.Controls.Add(this.lblPrenume);
            this.panouContinut.Controls.Add(this.lblNume);
            this.panouContinut.Controls.Add(this.txtPrenume);
            this.panouContinut.Controls.Add(this.txtNume);
            this.panouContinut.Location = new System.Drawing.Point(12, 45);
            this.panouContinut.Name = "panouContinut";
            this.panouContinut.Size = new System.Drawing.Size(395, 155);
            this.panouContinut.TabIndex = 0;
            // 
            // btnCiocCioc
            // 
            this.btnCiocCioc.Enabled = false;
            this.btnCiocCioc.Location = new System.Drawing.Point(94, 84);
            this.btnCiocCioc.Name = "btnCiocCioc";
            this.btnCiocCioc.Size = new System.Drawing.Size(107, 23);
            this.btnCiocCioc.TabIndex = 4;
            this.btnCiocCioc.Text = "Cioc Cioc!";
            this.btnCiocCioc.UseVisualStyleBackColor = true;
            this.btnCiocCioc.Click += new System.EventHandler(this.btnCiocCioc_Click);
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.Location = new System.Drawing.Point(39, 50);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(49, 13);
            this.lblPrenume.TabIndex = 3;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(47, 24);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 2;
            this.lblNume.Text = "Nume";
            // 
            // txtPrenume
            // 
            this.txtPrenume.Enabled = false;
            this.txtPrenume.Location = new System.Drawing.Point(94, 47);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(195, 20);
            this.txtPrenume.TabIndex = 1;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(94, 21);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(195, 20);
            this.txtNume.TabIndex = 0;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIesire});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnIesire
            // 
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.btnIesire.Size = new System.Drawing.Size(46, 20);
            this.btnIesire.Text = "I&esire";
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // frmAplicatiaLuViorel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 229);
            this.Controls.Add(this.panouContinut);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAplicatiaLuViorel";
            this.Text = "Aplicatia lu\' Viorel";
            this.panouContinut.ResumeLayout(false);
            this.panouContinut.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panouContinut;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Button btnCiocCioc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
    }
}

