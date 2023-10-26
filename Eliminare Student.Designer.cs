namespace POOProiect
{
    partial class Eliminare_Student
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
            this.eliminares_tb = new System.Windows.Forms.TextBox();
            this.confirm_es = new System.Windows.Forms.Button();
            this.back_es = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(53, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1181, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti numarul matricol al studentului pe care doriti sa il eliminati:";
            // 
            // eliminares_tb
            // 
            this.eliminares_tb.Location = new System.Drawing.Point(59, 163);
            this.eliminares_tb.Name = "eliminares_tb";
            this.eliminares_tb.Size = new System.Drawing.Size(308, 38);
            this.eliminares_tb.TabIndex = 1;
            // 
            // confirm_es
            // 
            this.confirm_es.Location = new System.Drawing.Point(59, 269);
            this.confirm_es.Name = "confirm_es";
            this.confirm_es.Size = new System.Drawing.Size(208, 79);
            this.confirm_es.TabIndex = 2;
            this.confirm_es.Text = "Confirmare";
            this.confirm_es.UseVisualStyleBackColor = true;
            this.confirm_es.Click += new System.EventHandler(this.confirm_es_Click);
            // 
            // back_es
            // 
            this.back_es.Location = new System.Drawing.Point(59, 485);
            this.back_es.Name = "back_es";
            this.back_es.Size = new System.Drawing.Size(160, 53);
            this.back_es.TabIndex = 3;
            this.back_es.Text = "Inapoi";
            this.back_es.UseVisualStyleBackColor = true;
            this.back_es.Click += new System.EventHandler(this.back_es_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1279, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 93);
            this.label2.TabIndex = 4;
            this.label2.Text = "UniCatalog";
            // 
            // Eliminare_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_es);
            this.Controls.Add(this.confirm_es);
            this.Controls.Add(this.eliminares_tb);
            this.Controls.Add(this.label1);
            this.Name = "Eliminare_Student";
            this.Text = "Eliminare_Student";
            this.Load += new System.EventHandler(this.Eliminare_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eliminares_tb;
        private System.Windows.Forms.Button confirm_es;
        private System.Windows.Forms.Button back_es;
        private System.Windows.Forms.Label label2;
    }
}