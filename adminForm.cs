using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp1
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
            Data();

        }
        public void Data()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = "select * from t_product";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            addpForm ad1 = new addpForm();
            ad1.ShowDialog();
            Data();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string pid = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string pname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string psepeci = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string pnumber = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                this.Hide();
                alterForm al1 = new alterForm(pid, pname, psepeci, pnumber);
                al1.ShowDialog();
                Data();
                this.Show();
            }
            catch
            {
                MessageBox.Show("error");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗?", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_product where pid={id}";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        Data();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }
                    dao.Daoclose();
                }

            }
            catch
            {
                MessageBox.Show("请选择要删除的记录", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }
        public void Idsearch()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_product where pid={textBox1.Text}";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }
        public void Namesearch()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"SELECT* FROM t_product WHERE pname LIKE '%{textBox2.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }
        public void Specisearch()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"SELECT* FROM t_product WHERE pspeci LIKE '%{textBox3.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }
        public void Numbersearch()
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_product where pnumber={textBox4.Text}";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString(), dc[3].ToString(), dc[4].ToString());
            }
            dc.Close();
            dao.Daoclose();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Idsearch();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Namesearch();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Specisearch();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Numbersearch();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Data();
        }
    }
}
