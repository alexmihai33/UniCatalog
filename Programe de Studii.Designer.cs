namespace POOProiect
{
    partial class Programe_de_Studii
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
            this.add_p = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_p = new System.Windows.Forms.Button();
            this.view_p = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.back_p = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_p
            // 
            this.add_p.Location = new System.Drawing.Point(118, 313);
            this.add_p.Name = "add_p";
            this.add_p.Size = new System.Drawing.Size(248, 89);
            this.add_p.TabIndex = 0;
            this.add_p.Text = "Adaugare Programa";
            this.add_p.UseVisualStyleBackColor = true;
            this.add_p.Click += new System.EventHandler(this.add_p_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "Programe de Studii";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(110, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alegeti o actiune:";
            // 
            // delete_p
            // 
            this.delete_p.Location = new System.Drawing.Point(446, 313);
            this.delete_p.Name = "delete_p";
            this.delete_p.Size = new System.Drawing.Size(235, 89);
            this.delete_p.TabIndex = 3;
            this.delete_p.Text = "Eliminare Programa";
            this.delete_p.UseVisualStyleBackColor = true;
            this.delete_p.Click += new System.EventHandler(this.delete_p_Click);
            // 
            // view_p
            // 
            this.view_p.Location = new System.Drawing.Point(778, 313);
            this.view_p.Name = "view_p";
            this.view_p.Size = new System.Drawing.Size(215, 89);
            this.view_p.TabIndex = 4;
            this.view_p.Text = "Vizualizare Programe";
            this.view_p.UseVisualStyleBackColor = true;
            this.view_p.Click += new System.EventHandler(this.view_p_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(942, 660);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 18;
            this.label6.Text = "UniCatalog";
            // 
            // back_p
            // 
            this.back_p.Location = new System.Drawing.Point(118, 660);
            this.back_p.Name = "back_p";
            this.back_p.Size = new System.Drawing.Size(142, 59);
            this.back_p.TabIndex = 19;
            this.back_p.Text = "Inapoi";
            this.back_p.UseVisualStyleBackColor = true;
            this.back_p.Click += new System.EventHandler(this.back_p_Click);
            // 
            // Programe_de_Studii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 796);
            this.Controls.Add(this.back_p);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.view_p);
            this.Controls.Add(this.delete_p);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_p);
            this.Name = "Programe_de_Studii";
            this.Text = "Programe_de_Studii";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_p;
        private System.Windows.Forms.Button view_p;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button back_p;
    }
}