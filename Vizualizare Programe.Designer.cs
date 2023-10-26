namespace POOProiect
{
    partial class Vizualizare_Programe
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
            this.vizualizare_p = new System.Windows.Forms.ListView();
            this.back_vp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vizualizare_p
            // 
            this.vizualizare_p.HideSelection = false;
            this.vizualizare_p.Location = new System.Drawing.Point(24, 23);
            this.vizualizare_p.Name = "vizualizare_p";
            this.vizualizare_p.Size = new System.Drawing.Size(1330, 643);
            this.vizualizare_p.TabIndex = 0;
            this.vizualizare_p.UseCompatibleStateImageBehavior = false;
            // 
            // back_vp
            // 
            this.back_vp.Location = new System.Drawing.Point(24, 739);
            this.back_vp.Name = "back_vp";
            this.back_vp.Size = new System.Drawing.Size(168, 72);
            this.back_vp.TabIndex = 1;
            this.back_vp.Text = "Inapoi";
            this.back_vp.UseVisualStyleBackColor = true;
            this.back_vp.Click += new System.EventHandler(this.back_vp_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1099, 725);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 18;
            this.label6.Text = "UniCatalog";
            // 
            // Vizualizare_Programe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 1000);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_vp);
            this.Controls.Add(this.vizualizare_p);
            this.Name = "Vizualizare_Programe";
            this.Text = "Vizualizare_Programe";
            this.Load += new System.EventHandler(this.Vizualizare_Programe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vizualizare_p;
        private System.Windows.Forms.Button back_vp;
        private System.Windows.Forms.Label label6;
    }
}