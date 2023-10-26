namespace POOProiect
{
    partial class Studenti
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
            this.add_s = new System.Windows.Forms.Button();
            this.vizualizare = new System.Windows.Forms.Button();
            this.delete_s = new System.Windows.Forms.Button();
            this.back_s = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // add_s
            // 
            this.add_s.Location = new System.Drawing.Point(47, 241);
            this.add_s.Name = "add_s";
            this.add_s.Size = new System.Drawing.Size(254, 79);
            this.add_s.TabIndex = 0;
            this.add_s.Text = "Adaugare Student";
            this.add_s.UseVisualStyleBackColor = true;
            this.add_s.Click += new System.EventHandler(this.add_s_Click);
            // 
            // vizualizare
            // 
            this.vizualizare.Location = new System.Drawing.Point(688, 241);
            this.vizualizare.Name = "vizualizare";
            this.vizualizare.Size = new System.Drawing.Size(255, 79);
            this.vizualizare.TabIndex = 1;
            this.vizualizare.Text = "Vizualizare Studenti";
            this.vizualizare.UseVisualStyleBackColor = true;
            this.vizualizare.Click += new System.EventHandler(this.vizualizare_Click);
            // 
            // delete_s
            // 
            this.delete_s.Location = new System.Drawing.Point(360, 241);
            this.delete_s.Name = "delete_s";
            this.delete_s.Size = new System.Drawing.Size(254, 79);
            this.delete_s.TabIndex = 2;
            this.delete_s.Text = "Eliminare Student";
            this.delete_s.UseVisualStyleBackColor = true;
            this.delete_s.Click += new System.EventHandler(this.delete_s_Click);
            // 
            // back_s
            // 
            this.back_s.Location = new System.Drawing.Point(47, 468);
            this.back_s.Name = "back_s";
            this.back_s.Size = new System.Drawing.Size(163, 59);
            this.back_s.TabIndex = 3;
            this.back_s.Text = "Inapoi";
            this.back_s.UseVisualStyleBackColor = true;
            this.back_s.Click += new System.EventHandler(this.back_s_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(786, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 85);
            this.label1.TabIndex = 4;
            this.label1.Text = "UniCatalog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(368, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "Gestionarea Studentilor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(41, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alegeti o actiune:";
            // 
            // Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 579);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_s);
            this.Controls.Add(this.delete_s);
            this.Controls.Add(this.vizualizare);
            this.Controls.Add(this.add_s);
            this.Name = "Studenti";
            this.Text = "Studenti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_s;
        private System.Windows.Forms.Button vizualizare;
        private System.Windows.Forms.Button delete_s;
        private System.Windows.Forms.Button back_s;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}