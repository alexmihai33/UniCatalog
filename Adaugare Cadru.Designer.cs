namespace POOProiect
{
    partial class Adaugare_Cadru
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
            this.numec_tb = new System.Windows.Forms.TextBox();
            this.prenumec_tb = new System.Windows.Forms.TextBox();
            this.marcac_tb = new System.Windows.Forms.TextBox();
            this.titluc_tb = new System.Windows.Forms.TextBox();
            this.confirm_c = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.back_ac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prenume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca Angajat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 412);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "titlu:";
            // 
            // numec_tb
            // 
            this.numec_tb.Location = new System.Drawing.Point(318, 143);
            this.numec_tb.Name = "numec_tb";
            this.numec_tb.Size = new System.Drawing.Size(194, 38);
            this.numec_tb.TabIndex = 4;
            // 
            // prenumec_tb
            // 
            this.prenumec_tb.Location = new System.Drawing.Point(318, 234);
            this.prenumec_tb.Name = "prenumec_tb";
            this.prenumec_tb.Size = new System.Drawing.Size(194, 38);
            this.prenumec_tb.TabIndex = 5;
            // 
            // marcac_tb
            // 
            this.marcac_tb.Location = new System.Drawing.Point(318, 326);
            this.marcac_tb.Name = "marcac_tb";
            this.marcac_tb.Size = new System.Drawing.Size(194, 38);
            this.marcac_tb.TabIndex = 6;
            // 
            // titluc_tb
            // 
            this.titluc_tb.Location = new System.Drawing.Point(318, 412);
            this.titluc_tb.Name = "titluc_tb";
            this.titluc_tb.Size = new System.Drawing.Size(194, 38);
            this.titluc_tb.TabIndex = 7;
            // 
            // confirm_c
            // 
            this.confirm_c.Location = new System.Drawing.Point(86, 510);
            this.confirm_c.Name = "confirm_c";
            this.confirm_c.Size = new System.Drawing.Size(273, 93);
            this.confirm_c.TabIndex = 8;
            this.confirm_c.Text = "Confirmare";
            this.confirm_c.UseVisualStyleBackColor = true;
            this.confirm_c.Click += new System.EventHandler(this.confirm_c_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(78, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 45);
            this.label5.TabIndex = 9;
            this.label5.Text = "Completati urmatoarele date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(846, 699);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 85);
            this.label6.TabIndex = 10;
            this.label6.Text = "UniCatalog";
            // 
            // back_ac
            // 
            this.back_ac.Location = new System.Drawing.Point(86, 708);
            this.back_ac.Name = "back_ac";
            this.back_ac.Size = new System.Drawing.Size(159, 54);
            this.back_ac.TabIndex = 11;
            this.back_ac.Text = "Inapoi";
            this.back_ac.UseVisualStyleBackColor = true;
            this.back_ac.Click += new System.EventHandler(this.back_ac_Click);
            // 
            // Adaugare_Cadru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 901);
            this.Controls.Add(this.back_ac);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.confirm_c);
            this.Controls.Add(this.titluc_tb);
            this.Controls.Add(this.marcac_tb);
            this.Controls.Add(this.prenumec_tb);
            this.Controls.Add(this.numec_tb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Adaugare_Cadru";
            this.Text = "Adaugare_Cadru";
            this.Load += new System.EventHandler(this.Adaugare_Cadru_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numec_tb;
        private System.Windows.Forms.TextBox prenumec_tb;
        private System.Windows.Forms.TextBox marcac_tb;
        private System.Windows.Forms.TextBox titluc_tb;
        private System.Windows.Forms.Button confirm_c;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_ac;
    }
}