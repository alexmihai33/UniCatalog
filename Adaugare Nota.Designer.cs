namespace POOProiect
{
    partial class Adaugare_Nota
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nr_mat_tb = new System.Windows.Forms.TextBox();
            this.disc_tb = new System.Windows.Forms.TextBox();
            this.nota_tb = new System.Windows.Forms.TextBox();
            this.confirm_an = new System.Windows.Forms.Button();
            this.Inapoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserati urmatoarele date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(413, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numarul matricol al studentului:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disciplina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota obtinuta:";
            // 
            // nr_mat_tb
            // 
            this.nr_mat_tb.Location = new System.Drawing.Point(662, 194);
            this.nr_mat_tb.Name = "nr_mat_tb";
            this.nr_mat_tb.Size = new System.Drawing.Size(152, 38);
            this.nr_mat_tb.TabIndex = 4;
            // 
            // disc_tb
            // 
            this.disc_tb.Location = new System.Drawing.Point(662, 276);
            this.disc_tb.Name = "disc_tb";
            this.disc_tb.Size = new System.Drawing.Size(152, 38);
            this.disc_tb.TabIndex = 5;
            // 
            // nota_tb
            // 
            this.nota_tb.Location = new System.Drawing.Point(662, 360);
            this.nota_tb.MaxLength = 2;
            this.nota_tb.Name = "nota_tb";
            this.nota_tb.Size = new System.Drawing.Size(66, 38);
            this.nota_tb.TabIndex = 6;
            // 
            // confirm_an
            // 
            this.confirm_an.Location = new System.Drawing.Point(164, 437);
            this.confirm_an.Name = "confirm_an";
            this.confirm_an.Size = new System.Drawing.Size(225, 94);
            this.confirm_an.TabIndex = 7;
            this.confirm_an.Text = "Confirmare";
            this.confirm_an.UseVisualStyleBackColor = true;
            this.confirm_an.Click += new System.EventHandler(this.confirm_an_Click);
            // 
            // Inapoi
            // 
            this.Inapoi.Location = new System.Drawing.Point(62, 592);
            this.Inapoi.Name = "Inapoi";
            this.Inapoi.Size = new System.Drawing.Size(158, 50);
            this.Inapoi.TabIndex = 8;
            this.Inapoi.Text = "Inapoi";
            this.Inapoi.UseVisualStyleBackColor = true;
            this.Inapoi.Click += new System.EventHandler(this.Inapoi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(768, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 19;
            this.label6.Text = "UniCatalog";
            // 
            // Adaugare_Nota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 709);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Inapoi);
            this.Controls.Add(this.confirm_an);
            this.Controls.Add(this.nota_tb);
            this.Controls.Add(this.disc_tb);
            this.Controls.Add(this.nr_mat_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adaugare_Nota";
            this.Text = "Adaugare_Nota";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nr_mat_tb;
        private System.Windows.Forms.TextBox disc_tb;
        private System.Windows.Forms.TextBox nota_tb;
        private System.Windows.Forms.Button confirm_an;
        private System.Windows.Forms.Button Inapoi;
        private System.Windows.Forms.Label label6;
    }
}