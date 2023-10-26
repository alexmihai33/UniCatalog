namespace POOProiect
{
    partial class Adaugare_Ciclu
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
            this.add_ci = new System.Windows.Forms.Button();
            this.add_ci_tb = new System.Windows.Forms.TextBox();
            this.cod_ci_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back_aci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_ci
            // 
            this.add_ci.Location = new System.Drawing.Point(87, 324);
            this.add_ci.Name = "add_ci";
            this.add_ci.Size = new System.Drawing.Size(212, 96);
            this.add_ci.TabIndex = 0;
            this.add_ci.Text = "Confirmare";
            this.add_ci.UseVisualStyleBackColor = true;
            this.add_ci.Click += new System.EventHandler(this.add_ci_Click);
            // 
            // add_ci_tb
            // 
            this.add_ci_tb.Location = new System.Drawing.Point(214, 254);
            this.add_ci_tb.Name = "add_ci_tb";
            this.add_ci_tb.Size = new System.Drawing.Size(272, 38);
            this.add_ci_tb.TabIndex = 1;
            // 
            // cod_ci_tb
            // 
            this.cod_ci_tb.Location = new System.Drawing.Point(214, 182);
            this.cod_ci_tb.MaxLength = 1;
            this.cod_ci_tb.Name = "cod_ci_tb";
            this.cod_ci_tb.Size = new System.Drawing.Size(36, 38);
            this.cod_ci_tb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nume:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(79, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(882, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Introduceti datele necesare unui ciclu de invatamant:";
            // 
            // back_aci
            // 
            this.back_aci.Location = new System.Drawing.Point(87, 477);
            this.back_aci.Name = "back_aci";
            this.back_aci.Size = new System.Drawing.Size(136, 57);
            this.back_aci.TabIndex = 6;
            this.back_aci.Text = "Inapoi";
            this.back_aci.UseVisualStyleBackColor = true;
            this.back_aci.Click += new System.EventHandler(this.back_aci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(800, 537);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 17;
            this.label6.Text = "UniCatalog";
            // 
            // Adaugare_Ciclu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 639);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_aci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cod_ci_tb);
            this.Controls.Add(this.add_ci_tb);
            this.Controls.Add(this.add_ci);
            this.Name = "Adaugare_Ciclu";
            this.Text = "Adaugare_Ciclu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_ci;
        private System.Windows.Forms.TextBox add_ci_tb;
        private System.Windows.Forms.TextBox cod_ci_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_aci;
        private System.Windows.Forms.Label label6;
    }
}