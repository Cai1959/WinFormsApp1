using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class userForm : Form
    {
        public userForm()
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

        private void button8_Click(object sender, EventArgs e)
        {
            Data();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Namesearch();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Specisearch();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Numbersearch();
        }
    }
}
