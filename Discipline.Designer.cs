namespace POOProiect
{
    partial class Discipline
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.add_d = new System.Windows.Forms.Button();
            this.delete_d = new System.Windows.Forms.Button();
            this.view_d = new System.Windows.Forms.Button();
            this.back_d = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discipline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(108, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(649, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alegeti una dintre urmatoarele actiuni:";
            // 
            // add_d
            // 
            this.add_d.Location = new System.Drawing.Point(116, 314);
            this.add_d.Name = "add_d";
            this.add_d.Size = new System.Drawing.Size(222, 85);
            this.add_d.TabIndex = 2;
            this.add_d.Text = "Adaugare disciplina";
            this.add_d.UseVisualStyleBackColor = true;
            this.add_d.Click += new System.EventHandler(this.add_d_Click);
            // 
            // delete_d
            // 
            this.delete_d.Location = new System.Drawing.Point(422, 314);
            this.delete_d.Name = "delete_d";
            this.delete_d.Size = new System.Drawing.Size(211, 85);
            this.delete_d.TabIndex = 3;
            this.delete_d.Text = "Eliminare Disciplina";
            this.delete_d.UseVisualStyleBackColor = true;
            this.delete_d.Click += new System.EventHandler(this.delete_d_Click);
            // 
            // view_d
            // 
            this.view_d.Location = new System.Drawing.Point(717, 314);
            this.view_d.Name = "view_d";
            this.view_d.Size = new System.Drawing.Size(222, 94);
            this.view_d.TabIndex = 6;
            this.view_d.Text = "Vizualizare Discipline";
            this.view_d.UseVisualStyleBackColor = true;
            this.view_d.Click += new System.EventHandler(this.view_d_Click);
            // 
            // back_d
            // 
            this.back_d.Location = new System.Drawing.Point(70, 504);
            this.back_d.Name = "back_d";
            this.back_d.Size = new System.Drawing.Size(160, 58);
            this.back_d.TabIndex = 7;
            this.back_d.Text = "Inapoi";
            this.back_d.UseVisualStyleBackColor = true;
            this.back_d.Click += new System.EventHandler(this.back_d_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(766, 477);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 85);
            this.label3.TabIndex = 8;
            this.label3.Text = "UniCatalog";
            // 
            // Discipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 815);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_d);
            this.Controls.Add(this.view_d);
            this.Controls.Add(this.delete_d);
            this.Controls.Add(this.add_d);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Discipline";
            this.Text = "Discipline";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add_d;
        private System.Windows.Forms.Button delete_d;
        private System.Windows.Forms.Button view_d;
        private System.Windows.Forms.Button back_d;
        private System.Windows.Forms.Label label3;
    }
}