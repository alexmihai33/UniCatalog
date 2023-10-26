namespace POOProiect
{
    partial class Vizualizare_Note
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
            this.vizualizare_n = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vizualizare_n
            // 
            this.vizualizare_n.HideSelection = false;
            this.vizualizare_n.Location = new System.Drawing.Point(34, 27);
            this.vizualizare_n.Name = "vizualizare_n";
            this.vizualizare_n.Size = new System.Drawing.Size(1062, 590);
            this.vizualizare_n.TabIndex = 0;
            this.vizualizare_n.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 682);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Inapoi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Niagara Solid", 26.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(841, 645);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 93);
            this.label6.TabIndex = 19;
            this.label6.Text = "UniCatalog";
            // 
            // Vizualizare_Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 951);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vizualizare_n);
            this.Name = "Vizualizare_Note";
            this.Text = "Vizualizare_Note";
            this.Load += new System.EventHandler(this.Vizualizare_Note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vizualizare_n;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
    }
}