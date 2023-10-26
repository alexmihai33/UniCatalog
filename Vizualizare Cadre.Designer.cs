namespace POOProiect
{
    partial class Vizualizare_Cadre
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
            this.vizualizare_c = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vizualizare_c
            // 
            this.vizualizare_c.HideSelection = false;
            this.vizualizare_c.Location = new System.Drawing.Point(12, 12);
            this.vizualizare_c.Name = "vizualizare_c";
            this.vizualizare_c.Size = new System.Drawing.Size(1111, 654);
            this.vizualizare_c.TabIndex = 0;
            this.vizualizare_c.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(868, 734);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 19;
            this.label6.Text = "UniCatalog";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 757);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 47);
            this.button1.TabIndex = 20;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Vizualizare_Cadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1460, 985);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.vizualizare_c);
            this.Name = "Vizualizare_Cadre";
            this.Text = "Vizualizare_Cadre";
            this.Load += new System.EventHandler(this.Vizualizare_Cadre_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vizualizare_c;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}