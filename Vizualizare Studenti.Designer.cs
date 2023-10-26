namespace POOProiect
{
    partial class Vizualizare_Studenti
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
            this.vizualizare_s = new System.Windows.Forms.ListView();
            this.back_vs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vizualizare_s
            // 
            this.vizualizare_s.HideSelection = false;
            this.vizualizare_s.Location = new System.Drawing.Point(12, 22);
            this.vizualizare_s.Name = "vizualizare_s";
            this.vizualizare_s.Size = new System.Drawing.Size(1240, 625);
            this.vizualizare_s.TabIndex = 0;
            this.vizualizare_s.UseCompatibleStateImageBehavior = false;
            this.vizualizare_s.SelectedIndexChanged += new System.EventHandler(this.vizualizare_s_SelectedIndexChanged);
            // 
            // back_vs
            // 
            this.back_vs.Location = new System.Drawing.Point(12, 740);
            this.back_vs.Name = "back_vs";
            this.back_vs.Size = new System.Drawing.Size(189, 63);
            this.back_vs.TabIndex = 1;
            this.back_vs.Text = "Inapoi";
            this.back_vs.UseVisualStyleBackColor = true;
            this.back_vs.Click += new System.EventHandler(this.back_vs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1024, 718);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 85);
            this.label1.TabIndex = 2;
            this.label1.Text = "UniCatalog";
            // 
            // Vizualizare_Studenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 901);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back_vs);
            this.Controls.Add(this.vizualizare_s);
            this.Name = "Vizualizare_Studenti";
            this.Text = "Vizualizare_Studenti";
            this.Load += new System.EventHandler(this.Vizualizare_Studenti_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vizualizare_s;
        private System.Windows.Forms.Button back_vs;
        private System.Windows.Forms.Label label1;
    }
}