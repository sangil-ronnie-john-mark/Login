namespace WinFormsApp4
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
            panel1 = new Panel();
            button1 = new Button();
            panel2 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(-23, -8);
            panel1.Name = "panel1";
            panel1.Size = new Size(846, 63);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(717, 20);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 0;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Maroon;
            panel2.Controls.Add(iconButton1);
            panel2.Location = new Point(-23, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(220, 408);
            panel2.TabIndex = 2;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.ForeColor = SystemColors.Control;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            iconButton1.IconColor = Color.FromArgb(224, 224, 224);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(35, 334);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(165, 41);
            iconButton1.TabIndex = 0;
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}