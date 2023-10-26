namespace POOProiect
{
    partial class Adaugare_Grupa
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
            this.confirm_ag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ci_tb = new System.Windows.Forms.TextBox();
            this.fi_tb = new System.Windows.Forms.TextBox();
            this.ps_tb = new System.Windows.Forms.TextBox();
            this.ca_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirm_ag
            // 
            this.confirm_ag.Location = new System.Drawing.Point(142, 495);
            this.confirm_ag.Name = "confirm_ag";
            this.confirm_ag.Size = new System.Drawing.Size(231, 96);
            this.confirm_ag.TabIndex = 0;
            this.confirm_ag.Text = "Confirmare";
            this.confirm_ag.UseVisualStyleBackColor = true;
            this.confirm_ag.Click += new System.EventHandler(this.confirm_ag_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(120, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(783, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduceti urmatoarele date pentru adaugare:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codul ciclului de invatamant:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codul formei de invatamant:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(136, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Codul programei de studiu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(429, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ultima cifra a anului de admitere:";
            // 
            // ci_tb
            // 
            this.ci_tb.Location = new System.Drawing.Point(661, 178);
            this.ci_tb.MaxLength = 1;
            this.ci_tb.Name = "ci_tb";
            this.ci_tb.Size = new System.Drawing.Size(44, 38);
            this.ci_tb.TabIndex = 6;
            // 
            // fi_tb
            // 
            this.fi_tb.Location = new System.Drawing.Point(661, 258);
            this.fi_tb.MaxLength = 1;
            this.fi_tb.Name = "fi_tb";
            this.fi_tb.Size = new System.Drawing.Size(44, 38);
            this.fi_tb.TabIndex = 7;
            // 
            // ps_tb
            // 
            this.ps_tb.Location = new System.Drawing.Point(661, 329);
            this.ps_tb.MaxLength = 1;
            this.ps_tb.Name = "ps_tb";
            this.ps_tb.Size = new System.Drawing.Size(44, 38);
            this.ps_tb.TabIndex = 8;
            // 
            // ca_tb
            // 
            this.ca_tb.Location = new System.Drawing.Point(661, 401);
            this.ca_tb.MaxLength = 1;
            this.ca_tb.Name = "ca_tb";
            this.ca_tb.Size = new System.Drawing.Size(44, 38);
            this.ca_tb.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 53);
            this.button1.TabIndex = 10;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(901, 618);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 18;
            this.label6.Text = "UniCatalog";
            // 
            // Adaugare_Grupa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 855);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ca_tb);
            this.Controls.Add(this.ps_tb);
            this.Controls.Add(this.fi_tb);
            this.Controls.Add(this.ci_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirm_ag);
            this.Name = "Adaugare_Grupa";
            this.Text = "Adaugare_Grupa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirm_ag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ci_tb;
        private System.Windows.Forms.TextBox fi_tb;
        private System.Windows.Forms.TextBox ps_tb;
        private System.Windows.Forms.TextBox ca_tb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}