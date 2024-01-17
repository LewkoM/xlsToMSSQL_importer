namespace ImporterApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.LogButton = new System.Windows.Forms.Button();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGOWANIE DO PROGRAMU";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.LogButton.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.LogButton.FlatAppearance.BorderSize = 0;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogButton.ForeColor = System.Drawing.Color.White;
            this.LogButton.Location = new System.Drawing.Point(127, 346);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(113, 33);
            this.LogButton.TabIndex = 3;
            this.LogButton.Text = "ZALOGUJ!";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.Button1_Click_1);
            this.LogButton.MouseEnter += new System.EventHandler(this.LogButton_MouseEnter);
            this.LogButton.MouseLeave += new System.EventHandler(this.LogButton_MouseLeave);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.White;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextBox.Location = new System.Drawing.Point(86, 78);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(167, 19);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.Text = "Wprowadź hasło";
            this.PasswordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.PasswordTextBox.Leave += new System.EventHandler(this.PasswordTextBox_Leave);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.White;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LoginTextBox.ForeColor = System.Drawing.Color.Black;
            this.LoginTextBox.Location = new System.Drawing.Point(88, 22);
            this.LoginTextBox.Multiline = true;
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(167, 20);
            this.LoginTextBox.TabIndex = 4;
            this.LoginTextBox.Text = "Wprowadź login";
            this.LoginTextBox.Click += new System.EventHandler(this.LoginTextBox_Click);
            this.LoginTextBox.TextChanged += new System.EventHandler(this.LoginTextBox_TextChanged);
            this.LoginTextBox.Leave += new System.EventHandler(this.LoginTextBox_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(-2, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 20);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(-2, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 20);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(-2, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 397);
            this.panel4.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(345, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(12, 391);
            this.panel2.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(85, 47);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 1);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(137)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(85, 101);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(166, 1);
            this.panel6.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.pictureBox2);
            this.panel7.Controls.Add(this.LoginTextBox);
            this.panel7.Controls.Add(this.PasswordTextBox);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Location = new System.Drawing.Point(41, 191);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(278, 124);
            this.panel7.TabIndex = 7;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ImporterApp.Properties.Resources.passIcon1;
            this.pictureBox3.Location = new System.Drawing.Point(42, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 28);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ImporterApp.Properties.Resources.userIC;
            this.pictureBox2.Location = new System.Drawing.Point(44, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::ImporterApp.Properties.Resources.user_icon_png_transparent_17;
            this.pictureBox1.Location = new System.Drawing.Point(142, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(355, 426);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Importer-logowanie";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

