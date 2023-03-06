using System.Data;

namespace WinFormsApp1
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("«Î ‰»Î’À∫≈ªÚ√‹¬Î");
            }
        }
        public void login()
        {
            if (radioButtonuser.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "SELECT * FROM t_user WHERE uid='" + textBox1.Text + "' AND upsw='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc != null)
                {
                    MessageBox.Show("µ«¬Ω≥…π¶");

                    userForm u1 = new userForm();
                    this.Hide();
                    u1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("’À∫≈ªÚ√‹¬Î¥ÌŒÛ");
                }
                dao.Daoclose();
            }
            else
            {
                Dao dao = new Dao();
                string sql = "SELECT * FROM t_admin WHERE aid='" + textBox1.Text + "' AND apsw='" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc != null)
                {
                    MessageBox.Show("µ«¬Ω≥…π¶");
                    adminForm a1 = new adminForm();
                    this.Hide();
                    a1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("’À∫≈ªÚ√‹¬Î¥ÌŒÛ");
                }
                dao.Daoclose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}