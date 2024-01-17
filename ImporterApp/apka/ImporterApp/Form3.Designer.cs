namespace ImporterApp
{
    partial class Form3
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
            this.GoBaseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FileButton = new System.Windows.Forms.Button();
            this.ImportButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // GoBaseButton
            // 
            this.GoBaseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.GoBaseButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.GoBaseButton.FlatAppearance.BorderSize = 0;
            this.GoBaseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoBaseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoBaseButton.ForeColor = System.Drawing.Color.White;
            this.GoBaseButton.Location = new System.Drawing.Point(77, 344);
            this.GoBaseButton.Name = "GoBaseButton";
            this.GoBaseButton.Size = new System.Drawing.Size(191, 59);
            this.GoBaseButton.TabIndex = 18;
            this.GoBaseButton.Text = "Wróc do konfiguracji bazy!";
            this.GoBaseButton.UseVisualStyleBackColor = false;
            this.GoBaseButton.Click += new System.EventHandler(this.GoBaseButton_Click);
            this.GoBaseButton.MouseEnter += new System.EventHandler(this.GoBaseButton_MouseEnter);
            this.GoBaseButton.MouseLeave += new System.EventHandler(this.GoBaseButton_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(344, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 391);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "WYBÓR PLIKU I IMPORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(-10, -4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 22);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(-7, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 397);
            this.panel4.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 17);
            this.panel1.TabIndex = 17;
            // 
            // FileButton
            // 
            this.FileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.FileButton.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.FileButton.FlatAppearance.BorderSize = 0;
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileButton.ForeColor = System.Drawing.Color.White;
            this.FileButton.Location = new System.Drawing.Point(75, 21);
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(157, 31);
            this.FileButton.TabIndex = 18;
            this.FileButton.Text = "Wybierz plik!";
            this.FileButton.UseVisualStyleBackColor = false;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            this.FileButton.MouseEnter += new System.EventHandler(this.FileButton_MouseEnter);
            this.FileButton.MouseLeave += new System.EventHandler(this.FileButton_MouseLeave);
            // 
            // ImportButton
            // 
            this.ImportButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.ImportButton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.ImportButton.FlatAppearance.BorderSize = 2;
            this.ImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImportButton.ForeColor = System.Drawing.Color.White;
            this.ImportButton.Location = new System.Drawing.Point(17, 161);
            this.ImportButton.Name = "ImportButton";
            this.ImportButton.Size = new System.Drawing.Size(281, 33);
            this.ImportButton.TabIndex = 18;
            this.ImportButton.Text = "Importuj!";
            this.ImportButton.UseVisualStyleBackColor = false;
            this.ImportButton.Click += new System.EventHandler(this.ImportButton_Click);
            this.ImportButton.MouseEnter += new System.EventHandler(this.Import_MouseEnter);
            this.ImportButton.MouseLeave += new System.EventHandler(this.ImportButton_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(103, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Wybrany plik:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.BackColor = System.Drawing.Color.White;
            this.FileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FileNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.FileNameTextBox.Location = new System.Drawing.Point(17, 98);
            this.FileNameTextBox.Multiline = true;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(281, 24);
            this.FileNameTextBox.TabIndex = 20;
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(17, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 1);
            this.panel5.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.FileButton);
            this.panel6.Controls.Add(this.ImportButton);
            this.panel6.Controls.Add(this.FileNameTextBox);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Location = new System.Drawing.Point(16, 105);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(322, 213);
            this.panel6.TabIndex = 22;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 426);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.GoBaseButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importer-wybór pliku i import";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GoBaseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button FileButton;
        private System.Windows.Forms.Button ImportButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}