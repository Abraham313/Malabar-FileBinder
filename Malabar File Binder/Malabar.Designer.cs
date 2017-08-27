namespace Malabar_File_Binder
{
    partial class Malabar
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.expinkTheme1 = new Theme.expinkTheme();
            this.ListofFileToBIND = new System.Windows.Forms.ListBox();
            this.expinkButton3 = new Theme.expinkButton();
            this.expinkTextBox1 = new Theme.expinkTextBox();
            this.expinkButton2 = new Theme.expinkButton();
            this.expinkButton1 = new Theme.expinkButton();
            this.expinkTheme1.SuspendLayout();
            this.SuspendLayout();
            // 
            // expinkTheme1
            // 
            this.expinkTheme1.CloseButtonExitsApp = false;
            this.expinkTheme1.Controls.Add(this.ListofFileToBIND);
            this.expinkTheme1.Controls.Add(this.expinkButton3);
            this.expinkTheme1.Controls.Add(this.expinkTextBox1);
            this.expinkTheme1.Controls.Add(this.expinkButton2);
            this.expinkTheme1.Controls.Add(this.expinkButton1);
            this.expinkTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expinkTheme1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.expinkTheme1.Location = new System.Drawing.Point(0, 0);
            this.expinkTheme1.MinimizeButton = false;
            this.expinkTheme1.Name = "expinkTheme1";
            this.expinkTheme1.Size = new System.Drawing.Size(704, 335);
            this.expinkTheme1.TabIndex = 0;
            this.expinkTheme1.Text = "Malabar Binder";
            // 
            // ListofFileToBIND
            // 
            this.ListofFileToBIND.BackColor = System.Drawing.SystemColors.MenuText;
            this.ListofFileToBIND.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListofFileToBIND.ForeColor = System.Drawing.Color.Fuchsia;
            this.ListofFileToBIND.FormattingEnabled = true;
            this.ListofFileToBIND.Location = new System.Drawing.Point(25, 50);
            this.ListofFileToBIND.Name = "ListofFileToBIND";
            this.ListofFileToBIND.Size = new System.Drawing.Size(506, 247);
            this.ListofFileToBIND.TabIndex = 6;
            // 
            // expinkButton3
            // 
            this.expinkButton3.BackColor = System.Drawing.Color.Transparent;
            this.expinkButton3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.expinkButton3.Location = new System.Drawing.Point(537, 252);
            this.expinkButton3.Name = "expinkButton3";
            this.expinkButton3.Size = new System.Drawing.Size(115, 49);
            this.expinkButton3.TabIndex = 5;
            this.expinkButton3.Text = "Bind";
            this.expinkButton3.TextAlignment = System.Drawing.StringAlignment.Near;
            this.expinkButton3.Click += new System.EventHandler(this.expinkButton3_Click);
            // 
            // expinkTextBox1
            // 
            this.expinkTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.expinkTextBox1.ForeColor = System.Drawing.Color.White;
            this.expinkTextBox1.Location = new System.Drawing.Point(537, 221);
            this.expinkTextBox1.MaxLength = 32767;
            this.expinkTextBox1.Name = "expinkTextBox1";
            this.expinkTextBox1.Size = new System.Drawing.Size(115, 25);
            this.expinkTextBox1.TabIndex = 4;
            this.expinkTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.expinkTextBox1.UseSystemPasswordChar = false;
            this.expinkTextBox1.Click += new System.EventHandler(this.expinkTextBox1_Click);
            // 
            // expinkButton2
            // 
            this.expinkButton2.BackColor = System.Drawing.Color.Transparent;
            this.expinkButton2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.expinkButton2.Location = new System.Drawing.Point(537, 134);
            this.expinkButton2.Name = "expinkButton2";
            this.expinkButton2.Size = new System.Drawing.Size(115, 30);
            this.expinkButton2.TabIndex = 3;
            this.expinkButton2.Text = "Remove File";
            this.expinkButton2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.expinkButton2.Click += new System.EventHandler(this.expinkButton2_Click);
            // 
            // expinkButton1
            // 
            this.expinkButton1.BackColor = System.Drawing.Color.Transparent;
            this.expinkButton1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.expinkButton1.Location = new System.Drawing.Point(537, 46);
            this.expinkButton1.Name = "expinkButton1";
            this.expinkButton1.Size = new System.Drawing.Size(115, 43);
            this.expinkButton1.TabIndex = 2;
            this.expinkButton1.Text = "Add File";
            this.expinkButton1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.expinkButton1.Click += new System.EventHandler(this.expinkButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 335);
            this.Controls.Add(this.expinkTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Malabar Binder";
            this.expinkTheme1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Theme.expinkTheme expinkTheme1;
        private Theme.expinkButton expinkButton3;
        private Theme.expinkTextBox expinkTextBox1;
        private Theme.expinkButton expinkButton2;
        private Theme.expinkButton expinkButton1;
        private System.Windows.Forms.ListBox ListofFileToBIND;
    }
}

