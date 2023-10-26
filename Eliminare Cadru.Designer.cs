namespace POOProiect
{
    partial class Eliminare_Cadru
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
            this.deletec_tb = new System.Windows.Forms.TextBox();
            this.deletec = new System.Windows.Forms.Button();
            this.back_ec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(64, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(900, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inserati marca angajatului pe care doriti sa il eliminati:";
            // 
            // deletec_tb
            // 
            this.deletec_tb.Location = new System.Drawing.Point(72, 166);
            this.deletec_tb.Name = "deletec_tb";
            this.deletec_tb.Size = new System.Drawing.Size(288, 38);
            this.deletec_tb.TabIndex = 1;
            // 
            // deletec
            // 
            this.deletec.Location = new System.Drawing.Point(72, 286);
            this.deletec.Name = "deletec";
            this.deletec.Size = new System.Drawing.Size(239, 78);
            this.deletec.TabIndex = 2;
            this.deletec.Text = "Confirmare";
            this.deletec.UseVisualStyleBackColor = true;
            this.deletec.Click += new System.EventHandler(this.deletec_Click);
            // 
            // back_ec
            // 
            this.back_ec.Location = new System.Drawing.Point(72, 550);
            this.back_ec.Name = "back_ec";
            this.back_ec.Size = new System.Drawing.Size(119, 50);
            this.back_ec.TabIndex = 3;
            this.back_ec.Text = "Inapoi";
            this.back_ec.UseVisualStyleBackColor = true;
            this.back_ec.Click += new System.EventHandler(this.back_ec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(895, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 85);
            this.label2.TabIndex = 4;
            this.label2.Text = "UniCatalog";
            // 
            // Eliminare_Cadru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 686);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_ec);
            this.Controls.Add(this.deletec);
            this.Controls.Add(this.deletec_tb);
            this.Controls.Add(this.label1);
            this.Name = "Eliminare_Cadru";
            this.Text = "Eliminare_Cadru";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deletec_tb;
        private System.Windows.Forms.Button deletec;
        private System.Windows.Forms.Button back_ec;
        private System.Windows.Forms.Label label2;
    }
}