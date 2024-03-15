namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}