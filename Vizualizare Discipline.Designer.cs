namespace POOProiect
{
    partial class Vizualizare_Discipline
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
            this.vizualizare_d = new System.Windows.Forms.ListView();
            this.back_vd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.programe_d_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vizualizare_d
            // 
            this.vizualizare_d.HideSelection = false;
            this.vizualizare_d.Location = new System.Drawing.Point(31, 192);
            this.vizualizare_d.Name = "vizualizare_d";
            this.vizualizare_d.Size = new System.Drawing.Size(1234, 447);
            this.vizualizare_d.TabIndex = 0;
            this.vizualizare_d.UseCompatibleStateImageBehavior = false;
            // 
            // back_vd
            // 
            this.back_vd.Location = new System.Drawing.Point(31, 692);
            this.back_vd.Name = "back_vd";
            this.back_vd.Size = new System.Drawing.Size(137, 61);
            this.back_vd.TabIndex = 1;
            this.back_vd.Text = "Inapoi";
            this.back_vd.UseVisualStyleBackColor = true;
            this.back_vd.Click += new System.EventHandler(this.back_vd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(23, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1017, 45);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pentru vizualizarea disciplinelor, selectati programa de studii:";
            // 
            // programe_d_cb
            // 
            this.programe_d_cb.FormattingEnabled = true;
            this.programe_d_cb.Location = new System.Drawing.Point(31, 126);
            this.programe_d_cb.Name = "programe_d_cb";
            this.programe_d_cb.Size = new System.Drawing.Size(219, 39);
            this.programe_d_cb.TabIndex = 6;
            this.programe_d_cb.SelectedIndexChanged += new System.EventHandler(this.programe_d_cb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1037, 668);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 85);
            this.label1.TabIndex = 7;
            this.label1.Text = "UniCatalog";
            // 
            // Vizualizare_Discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 1096);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.programe_d_cb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_vd);
            this.Controls.Add(this.vizualizare_d);
            this.Name = "Vizualizare_Discipline";
            this.Text = "Vizualizare_Discipline";
            this.Load += new System.EventHandler(this.Vizualizare_Discipline_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView vizualizare_d;
        private System.Windows.Forms.Button back_vd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox programe_d_cb;
        private System.Windows.Forms.Label label1;
    }
}