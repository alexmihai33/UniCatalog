namespace POOProiect
{
    partial class Vizualizare_Cicluri
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
            this.vizualizare_ci = new System.Windows.Forms.ListView();
            this.back_vci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vizualizare_ci
            // 
            this.vizualizare_ci.HideSelection = false;
            this.vizualizare_ci.Location = new System.Drawing.Point(42, 27);
            this.vizualizare_ci.Name = "vizualizare_ci";
            this.vizualizare_ci.Size = new System.Drawing.Size(1024, 575);
            this.vizualizare_ci.TabIndex = 0;
            this.vizualizare_ci.UseCompatibleStateImageBehavior = false;
            // 
            // back_vci
            // 
            this.back_vci.Location = new System.Drawing.Point(42, 631);
            this.back_vci.Name = "back_vci";
            this.back_vci.Size = new System.Drawing.Size(165, 70);
            this.back_vci.TabIndex = 1;
            this.back_vci.Text = "Inapoi";
            this.back_vci.UseVisualStyleBackColor = true;
            this.back_vci.Click += new System.EventHandler(this.back_vci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1082, 668);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 17;
            this.label6.Text = "UniCatalog";
            // 
            // Vizualizare_Cicluri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 770);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.back_vci);
            this.Controls.Add(this.vizualizare_ci);
            this.Name = "Vizualizare_Cicluri";
            this.Text = "Vizualizare_Cicluri";
            this.Load += new System.EventHandler(this.Vizualizare_Cicluri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vizualizare_ci;
        private System.Windows.Forms.Button back_vci;
        private System.Windows.Forms.Label label6;
    }
}