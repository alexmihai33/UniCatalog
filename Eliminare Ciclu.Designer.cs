namespace POOProiect
{
    partial class Eliminare_Ciclu
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
            this.delete_ci = new System.Windows.Forms.Button();
            this.delete_ci_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.back_eci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete_ci
            // 
            this.delete_ci.Location = new System.Drawing.Point(45, 243);
            this.delete_ci.Name = "delete_ci";
            this.delete_ci.Size = new System.Drawing.Size(218, 92);
            this.delete_ci.TabIndex = 0;
            this.delete_ci.Text = "Confirmare";
            this.delete_ci.UseVisualStyleBackColor = true;
            this.delete_ci.Click += new System.EventHandler(this.delete_ci_Click);
            // 
            // delete_ci_tb
            // 
            this.delete_ci_tb.Location = new System.Drawing.Point(45, 137);
            this.delete_ci_tb.MaxLength = 1;
            this.delete_ci_tb.Name = "delete_ci_tb";
            this.delete_ci_tb.Size = new System.Drawing.Size(52, 38);
            this.delete_ci_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(37, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(939, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Introduceti codul ciclului de invatamant pentru stergere:";
            // 
            // back_eci
            // 
            this.back_eci.Location = new System.Drawing.Point(45, 466);
            this.back_eci.Name = "back_eci";
            this.back_eci.Size = new System.Drawing.Size(132, 62);
            this.back_eci.TabIndex = 3;
            this.back_eci.Text = "Inapoi";
            this.back_eci.UseVisualStyleBackColor = true;
            this.back_eci.Click += new System.EventHandler(this.back_eci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(882, 553);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 17;
            this.label6.Text = "UniCatalog";
            // 
            // Eliminare_Ciclu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 655);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_eci);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_ci_tb);
            this.Controls.Add(this.delete_ci);
            this.Name = "Eliminare_Ciclu";
            this.Text = "Eliminare_Ciclu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete_ci;
        private System.Windows.Forms.TextBox delete_ci_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_eci;
        private System.Windows.Forms.Label label6;
    }
}