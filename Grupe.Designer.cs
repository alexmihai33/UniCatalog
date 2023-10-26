namespace POOProiect
{
    partial class Grupe
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
            this.add_g = new System.Windows.Forms.Button();
            this.elim_g = new System.Windows.Forms.Button();
            this.view_g = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestionare Grupe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(119, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alegeti una dintre urmatoarele actiuni:";
            // 
            // add_g
            // 
            this.add_g.Location = new System.Drawing.Point(127, 265);
            this.add_g.Name = "add_g";
            this.add_g.Size = new System.Drawing.Size(247, 89);
            this.add_g.TabIndex = 2;
            this.add_g.Text = "Adaugare Grupa";
            this.add_g.UseVisualStyleBackColor = true;
            this.add_g.Click += new System.EventHandler(this.add_g_Click);
            // 
            // elim_g
            // 
            this.elim_g.Location = new System.Drawing.Point(441, 265);
            this.elim_g.Name = "elim_g";
            this.elim_g.Size = new System.Drawing.Size(210, 89);
            this.elim_g.TabIndex = 3;
            this.elim_g.Text = "Eliminare Grupa";
            this.elim_g.UseVisualStyleBackColor = true;
            this.elim_g.Click += new System.EventHandler(this.elim_g_Click);
            // 
            // view_g
            // 
            this.view_g.Location = new System.Drawing.Point(735, 265);
            this.view_g.Name = "view_g";
            this.view_g.Size = new System.Drawing.Size(212, 89);
            this.view_g.TabIndex = 4;
            this.view_g.Text = "Vizualizare Grupe";
            this.view_g.UseVisualStyleBackColor = true;
            this.view_g.Click += new System.EventHandler(this.view_g_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(988, 503);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 18;
            this.label6.Text = "UniCatalog";
            // 
            // Grupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 753);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.view_g);
            this.Controls.Add(this.elim_g);
            this.Controls.Add(this.add_g);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Grupe";
            this.Text = "Grupe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_g;
        private System.Windows.Forms.Button elim_g;
        private System.Windows.Forms.Button view_g;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}