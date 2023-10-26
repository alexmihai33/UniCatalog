namespace POOProiect
{
    partial class Inregistrare
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
            this.user_lab_i = new System.Windows.Forms.Label();
            this.pass_lab_i = new System.Windows.Forms.Label();
            this.user_tb_i = new System.Windows.Forms.TextBox();
            this.pass_tb_i = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.admin_cb = new System.Windows.Forms.CheckBox();
            this.secretar_cb = new System.Windows.Forms.CheckBox();
            this.cadru_cb = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // user_lab_i
            // 
            this.user_lab_i.AutoSize = true;
            this.user_lab_i.Location = new System.Drawing.Point(55, 50);
            this.user_lab_i.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.user_lab_i.Name = "user_lab_i";
            this.user_lab_i.Size = new System.Drawing.Size(32, 13);
            this.user_lab_i.TabIndex = 0;
            this.user_lab_i.Text = "User:";
            // 
            // pass_lab_i
            // 
            this.pass_lab_i.AutoSize = true;
            this.pass_lab_i.Location = new System.Drawing.Point(55, 89);
            this.pass_lab_i.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.pass_lab_i.Name = "pass_lab_i";
            this.pass_lab_i.Size = new System.Drawing.Size(40, 13);
            this.pass_lab_i.TabIndex = 1;
            this.pass_lab_i.Text = "Parola:";
            // 
            // user_tb_i
            // 
            this.user_tb_i.Location = new System.Drawing.Point(138, 48);
            this.user_tb_i.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.user_tb_i.Name = "user_tb_i";
            this.user_tb_i.Size = new System.Drawing.Size(112, 20);
            this.user_tb_i.TabIndex = 2;
            // 
            // pass_tb_i
            // 
            this.pass_tb_i.Location = new System.Drawing.Point(138, 87);
            this.pass_tb_i.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pass_tb_i.Name = "pass_tb_i";
            this.pass_tb_i.Size = new System.Drawing.Size(112, 20);
            this.pass_tb_i.TabIndex = 3;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.Control;
            this.register.Location = new System.Drawing.Point(57, 198);
            this.register.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(88, 29);
            this.register.TabIndex = 13;
            this.register.Text = "Inregistrare";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(55, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selectati functiile pe care le are contul dumneavoastra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Daca aveti deja cont, va puteti loga:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(57, 271);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Logare";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admin_cb
            // 
            this.admin_cb.AutoSize = true;
            this.admin_cb.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.admin_cb.Location = new System.Drawing.Point(57, 163);
            this.admin_cb.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.admin_cb.Name = "admin_cb";
            this.admin_cb.Size = new System.Drawing.Size(120, 24);
            this.admin_cb.TabIndex = 17;
            this.admin_cb.Text = "Administrator";
            this.admin_cb.UseVisualStyleBackColor = true;
            // 
            // secretar_cb
            // 
            this.secretar_cb.AutoSize = true;
            this.secretar_cb.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.secretar_cb.Location = new System.Drawing.Point(187, 163);
            this.secretar_cb.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.secretar_cb.Name = "secretar_cb";
            this.secretar_cb.Size = new System.Drawing.Size(82, 24);
            this.secretar_cb.TabIndex = 18;
            this.secretar_cb.Text = "Secretar";
            this.secretar_cb.UseVisualStyleBackColor = true;
            // 
            // cadru_cb
            // 
            this.cadru_cb.AutoSize = true;
            this.cadru_cb.Font = new System.Drawing.Font("Microsoft YaHei", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cadru_cb.Location = new System.Drawing.Point(285, 163);
            this.cadru_cb.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cadru_cb.Name = "cadru_cb";
            this.cadru_cb.Size = new System.Drawing.Size(127, 24);
            this.cadru_cb.TabIndex = 19;
            this.cadru_cb.Text = "Cadru Didactic";
            this.cadru_cb.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 296);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 34);
            this.label3.TabIndex = 20;
            this.label3.Text = "UniCatalog";
            // 
            // Inregistrare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(475, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cadru_cb);
            this.Controls.Add(this.secretar_cb);
            this.Controls.Add(this.admin_cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.pass_tb_i);
            this.Controls.Add(this.user_tb_i);
            this.Controls.Add(this.pass_lab_i);
            this.Controls.Add(this.user_lab_i);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Inregistrare";
            this.Text = "Inregistrare";
            this.Load += new System.EventHandler(this.Inregistrare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_lab_i;
        private System.Windows.Forms.Label pass_lab_i;
        private System.Windows.Forms.TextBox user_tb_i;
        private System.Windows.Forms.TextBox pass_tb_i;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox admin_cb;
        private System.Windows.Forms.CheckBox secretar_cb;
        private System.Windows.Forms.CheckBox cadru_cb;
        private System.Windows.Forms.Label label3;
    }
}