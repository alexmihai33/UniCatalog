namespace POOProiect
{
    partial class Cicluri_de_Invatamant
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
            this.delete_ci = new System.Windows.Forms.Button();
            this.vizualizare_ci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_ci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // add_ci
            // 
            this.add_ci.Location = new System.Drawing.Point(81, 240);
            this.add_ci.Name = "add_ci";
            this.add_ci.Size = new System.Drawing.Size(236, 89);
            this.add_ci.TabIndex = 0;
            this.add_ci.Text = "Adaugarea Ciclu";
            this.add_ci.UseVisualStyleBackColor = true;
            this.add_ci.Click += new System.EventHandler(this.add_ci_Click);
            // 
            // delete_ci
            // 
            this.delete_ci.Location = new System.Drawing.Point(387, 240);
            this.delete_ci.Name = "delete_ci";
            this.delete_ci.Size = new System.Drawing.Size(223, 89);
            this.delete_ci.TabIndex = 1;
            this.delete_ci.Text = "Eliminare Ciclu";
            this.delete_ci.UseVisualStyleBackColor = true;
            this.delete_ci.Click += new System.EventHandler(this.delete_ci_Click);
            // 
            // vizualizare_ci
            // 
            this.vizualizare_ci.Location = new System.Drawing.Point(711, 240);
            this.vizualizare_ci.Name = "vizualizare_ci";
            this.vizualizare_ci.Size = new System.Drawing.Size(226, 89);
            this.vizualizare_ci.TabIndex = 2;
            this.vizualizare_ci.Text = "Vizualizare Cicluri";
            this.vizualizare_ci.UseVisualStyleBackColor = true;
            this.vizualizare_ci.Click += new System.EventHandler(this.vizualizare_ci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(936, 506);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 17;
            this.label6.Text = "UniCatalog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 72);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cicluri de invatamant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(77, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(359, 52);
            this.label2.TabIndex = 19;
            this.label2.Text = "Alegeti o actiune:";
            // 
            // back_ci
            // 
            this.back_ci.Location = new System.Drawing.Point(65, 528);
            this.back_ci.Name = "back_ci";
            this.back_ci.Size = new System.Drawing.Size(146, 55);
            this.back_ci.TabIndex = 20;
            this.back_ci.Text = "Inapoi";
            this.back_ci.UseVisualStyleBackColor = true;
            this.back_ci.Click += new System.EventHandler(this.back_ci_Click);
            // 
            // Cicluri_de_Invatamant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 680);
            this.Controls.Add(this.back_ci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vizualizare_ci);
            this.Controls.Add(this.delete_ci);
            this.Controls.Add(this.add_ci);
            this.Name = "Cicluri_de_Invatamant";
            this.Text = "Cicluri_de_Invatamant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_ci;
        private System.Windows.Forms.Button delete_ci;
        private System.Windows.Forms.Button vizualizare_ci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_ci;
    }
}