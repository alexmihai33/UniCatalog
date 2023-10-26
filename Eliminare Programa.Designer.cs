namespace POOProiect
{
    partial class Eliminare_Programa
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
            this.delete_p_tb = new System.Windows.Forms.TextBox();
            this.confirm_ep = new System.Windows.Forms.Button();
            this.back_ep = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(56, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(906, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti codul programei pentru eliminare:";
            // 
            // delete_p_tb
            // 
            this.delete_p_tb.Location = new System.Drawing.Point(65, 164);
            this.delete_p_tb.MaxLength = 1;
            this.delete_p_tb.Name = "delete_p_tb";
            this.delete_p_tb.Size = new System.Drawing.Size(49, 38);
            this.delete_p_tb.TabIndex = 1;
            // 
            // confirm_ep
            // 
            this.confirm_ep.Location = new System.Drawing.Point(65, 229);
            this.confirm_ep.Name = "confirm_ep";
            this.confirm_ep.Size = new System.Drawing.Size(245, 95);
            this.confirm_ep.TabIndex = 2;
            this.confirm_ep.Text = "Confirmare";
            this.confirm_ep.UseVisualStyleBackColor = true;
            this.confirm_ep.Click += new System.EventHandler(this.confirm_ep_Click);
            // 
            // back_ep
            // 
            this.back_ep.Location = new System.Drawing.Point(65, 416);
            this.back_ep.Name = "back_ep";
            this.back_ep.Size = new System.Drawing.Size(142, 68);
            this.back_ep.TabIndex = 3;
            this.back_ep.Text = "Inapoi";
            this.back_ep.UseVisualStyleBackColor = true;
            this.back_ep.Click += new System.EventHandler(this.back_ep_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(879, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 18;
            this.label6.Text = "UniCatalog";
            // 
            // Eliminare_Programa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_ep);
            this.Controls.Add(this.confirm_ep);
            this.Controls.Add(this.delete_p_tb);
            this.Controls.Add(this.label1);
            this.Name = "Eliminare_Programa";
            this.Text = "Eliminare_Programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delete_p_tb;
        private System.Windows.Forms.Button confirm_ep;
        private System.Windows.Forms.Button back_ep;
        private System.Windows.Forms.Label label6;
    }
}