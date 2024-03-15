namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cbxPassword = new CheckBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-5, -10);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 55);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(509, 16);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 0;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 154);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(286, 84);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(271, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(286, 123);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(271, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(205, 91);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 4;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(205, 130);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(205, 166);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 6;
            label3.Text = "Show Password";
            // 
            // cbxPassword
            // 
            cbxPassword.AutoSize = true;
            cbxPassword.Location = new Point(332, 169);
            cbxPassword.Name = "cbxPassword";
            cbxPassword.Size = new Size(18, 17);
            cbxPassword.TabIndex = 7;
            cbxPassword.UseVisualStyleBackColor = true;
            cbxPassword.CheckedChanged += cbxPassword_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(205, 192);
            button2.Name = "button2";
            button2.Size = new Size(352, 29);
            button2.TabIndex = 8;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 253);
            Controls.Add(button2);
            Controls.Add(cbxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox cbxPassword;
        private Button button2;
    }
}