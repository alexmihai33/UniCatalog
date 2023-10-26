namespace POOProiect
{
    partial class Eliminare_Disciplina
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
            this.delete_d_tb = new System.Windows.Forms.TextBox();
            this.confirm_ed = new System.Windows.Forms.Button();
            this.back_ed = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(47, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(760, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti codul disciplinei pentru eliminare:";
            // 
            // delete_d_tb
            // 
            this.delete_d_tb.Location = new System.Drawing.Point(112, 142);
            this.delete_d_tb.Name = "delete_d_tb";
            this.delete_d_tb.Size = new System.Drawing.Size(161, 38);
            this.delete_d_tb.TabIndex = 1;
            // 
            // confirm_ed
            // 
            this.confirm_ed.Location = new System.Drawing.Point(112, 260);
            this.confirm_ed.Name = "confirm_ed";
            this.confirm_ed.Size = new System.Drawing.Size(222, 93);
            this.confirm_ed.TabIndex = 2;
            this.confirm_ed.Text = "Confirmare";
            this.confirm_ed.UseVisualStyleBackColor = true;
            this.confirm_ed.Click += new System.EventHandler(this.confirm_ed_Click);
            // 
            // back_ed
            // 
            this.back_ed.Location = new System.Drawing.Point(55, 452);
            this.back_ed.Name = "back_ed";
            this.back_ed.Size = new System.Drawing.Size(145, 59);
            this.back_ed.TabIndex = 3;
            this.back_ed.Text = "Inapoi";
            this.back_ed.UseVisualStyleBackColor = true;
            this.back_ed.Click += new System.EventHandler(this.back_ed_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(803, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 85);
            this.label3.TabIndex = 5;
            this.label3.Text = "UniCatalog";
            // 
            // Eliminare_Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 647);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_ed);
            this.Controls.Add(this.confirm_ed);
            this.Controls.Add(this.delete_d_tb);
            this.Controls.Add(this.label1);
            this.Name = "Eliminare_Disciplina";
            this.Text = "Eliminare_Disciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delete_d_tb;
        private System.Windows.Forms.Button confirm_ed;
        private System.Windows.Forms.Button back_ed;
        private System.Windows.Forms.Label label3;
    }
}