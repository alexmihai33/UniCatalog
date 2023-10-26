namespace POOProiect
{
    partial class Cadre
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
            this.add_c = new System.Windows.Forms.Button();
            this.delete_c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.back_c = new System.Windows.Forms.Button();
            this.view_c = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_c
            // 
            this.add_c.Location = new System.Drawing.Point(75, 258);
            this.add_c.Name = "add_c";
            this.add_c.Size = new System.Drawing.Size(257, 77);
            this.add_c.TabIndex = 0;
            this.add_c.Text = "Adaugare Cadru";
            this.add_c.UseVisualStyleBackColor = true;
            this.add_c.Click += new System.EventHandler(this.add_c_Click);
            // 
            // delete_c
            // 
            this.delete_c.Location = new System.Drawing.Point(400, 259);
            this.delete_c.Name = "delete_c";
            this.delete_c.Size = new System.Drawing.Size(261, 76);
            this.delete_c.TabIndex = 1;
            this.delete_c.Text = "Eliminare Cadru";
            this.delete_c.UseVisualStyleBackColor = true;
            this.delete_c.Click += new System.EventHandler(this.delete_c_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestionarea Cadrelor Didactice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(69, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alegeti o actiune:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(870, 523);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 85);
            this.label3.TabIndex = 4;
            this.label3.Text = "UniCatalog";
            // 
            // back_c
            // 
            this.back_c.Location = new System.Drawing.Point(75, 548);
            this.back_c.Name = "back_c";
            this.back_c.Size = new System.Drawing.Size(143, 48);
            this.back_c.TabIndex = 5;
            this.back_c.Text = "Inapoi";
            this.back_c.UseVisualStyleBackColor = true;
            this.back_c.Click += new System.EventHandler(this.back_c_Click);
            // 
            // view_c
            // 
            this.view_c.Location = new System.Drawing.Point(749, 259);
            this.view_c.Name = "view_c";
            this.view_c.Size = new System.Drawing.Size(265, 76);
            this.view_c.TabIndex = 6;
            this.view_c.Text = "Vizualizare Cadre";
            this.view_c.UseVisualStyleBackColor = true;
            this.view_c.Click += new System.EventHandler(this.view_c_Click);
            // 
            // Cadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 617);
            this.Controls.Add(this.view_c);
            this.Controls.Add(this.back_c);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_c);
            this.Controls.Add(this.add_c);
            this.Name = "Cadre";
            this.Text = "Cadre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_c;
        private System.Windows.Forms.Button delete_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button back_c;
        private System.Windows.Forms.Button view_c;
    }
}