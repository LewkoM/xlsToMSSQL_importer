namespace ImporterApp
{
    partial class Form2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CatalogBaseTextBox = new System.Windows.Forms.TextBox();
            this.LoginBaseTextBox = new System.Windows.Forms.TextBox();
            this.NameBaseTextBox = new System.Windows.Forms.TextBox();
            this.PasswordBaseTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GoImportButton = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(344, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 391);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "KONFIGURACJA BAZY DANYCH";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 17);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 397);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 21);
            this.panel1.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.CatalogBaseTextBox);
            this.panel7.Controls.Add(this.LoginBaseTextBox);
            this.panel7.Controls.Add(this.NameBaseTextBox);
            this.panel7.Controls.Add(this.PasswordBaseTextBox);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Location = new System.Drawing.Point(26, 64);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 287);
            this.panel7.TabIndex = 11;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // CatalogBaseTextBox
            // 
            this.CatalogBaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CatalogBaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CatalogBaseTextBox.Location = new System.Drawing.Point(59, 177);
            this.CatalogBaseTextBox.Multiline = true;
            this.CatalogBaseTextBox.Name = "CatalogBaseTextBox";
            this.CatalogBaseTextBox.Size = new System.Drawing.Size(166, 20);
            this.CatalogBaseTextBox.TabIndex = 6;
            this.CatalogBaseTextBox.TextChanged += new System.EventHandler(this.CatalogTextBox_TextChanged);
            // 
            // LoginBaseTextBox
            // 
            this.LoginBaseTextBox.BackColor = System.Drawing.Color.White;
            this.LoginBaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginBaseTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginBaseTextBox.Location = new System.Drawing.Point(59, 35);
            this.LoginBaseTextBox.Multiline = true;
            this.LoginBaseTextBox.Name = "LoginBaseTextBox";
            this.LoginBaseTextBox.Size = new System.Drawing.Size(167, 20);
            this.LoginBaseTextBox.TabIndex = 4;
            this.LoginBaseTextBox.TextChanged += new System.EventHandler(this.LoginBaseTextBox_TextChanged);
            // 
            // NameBaseTextBox
            // 
            this.NameBaseTextBox.BackColor = System.Drawing.Color.White;
            this.NameBaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameBaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameBaseTextBox.ForeColor = System.Drawing.Color.Black;
            this.NameBaseTextBox.Location = new System.Drawing.Point(15, 235);
            this.NameBaseTextBox.Multiline = true;
            this.NameBaseTextBox.Name = "NameBaseTextBox";
            this.NameBaseTextBox.PasswordChar = '*';
            this.NameBaseTextBox.Size = new System.Drawing.Size(264, 21);
            this.NameBaseTextBox.TabIndex = 4;
            this.NameBaseTextBox.UseSystemPasswordChar = true;
            this.NameBaseTextBox.TextChanged += new System.EventHandler(this.NameBaseTextBox_TextChanged);
            // 
            // PasswordBaseTextBox
            // 
            this.PasswordBaseTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordBaseTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBaseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordBaseTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordBaseTextBox.Location = new System.Drawing.Point(58, 101);
            this.PasswordBaseTextBox.Multiline = true;
            this.PasswordBaseTextBox.Name = "PasswordBaseTextBox";
            this.PasswordBaseTextBox.PasswordChar = '*';
            this.PasswordBaseTextBox.Size = new System.Drawing.Size(167, 21);
            this.PasswordBaseTextBox.TabIndex = 4;
            this.PasswordBaseTextBox.TextChanged += new System.EventHandler(this.PasswordBaseTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(99, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nazwa instacji:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(116, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasło:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(79, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nazwa bazy danych:";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(57, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 1);
            this.panel5.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel9.Location = new System.Drawing.Point(57, 199);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(169, 1);
            this.panel9.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(122, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel8.Location = new System.Drawing.Point(15, 262);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(264, 1);
            this.panel8.TabIndex = 5;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(59, 124);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(166, 1);
            this.panel6.TabIndex = 5;
            // 
            // GoImportButton
            // 
            this.GoImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.GoImportButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.GoImportButton.FlatAppearance.BorderSize = 0;
            this.GoImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoImportButton.ForeColor = System.Drawing.Color.White;
            this.GoImportButton.Location = new System.Drawing.Point(73, 369);
            this.GoImportButton.Name = "GoImportButton";
            this.GoImportButton.Size = new System.Drawing.Size(191, 33);
            this.GoImportButton.TabIndex = 12;
            this.GoImportButton.Text = "Przejdź do importu!";
            this.GoImportButton.UseVisualStyleBackColor = false;
            this.GoImportButton.Click += new System.EventHandler(this.GoImportButton_Click);
            this.GoImportButton.MouseEnter += new System.EventHandler(this.GoImportButton_MouseEnter);
            this.GoImportButton.MouseLeave += new System.EventHandler(this.GoImportButton_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 426);
            this.Controls.Add(this.GoImportButton);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importer-konfiguracja bazy danych";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox LoginBaseTextBox;
        private System.Windows.Forms.TextBox PasswordBaseTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox NameBaseTextBox;
        private System.Windows.Forms.Button GoImportButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox CatalogBaseTextBox;
    }
}