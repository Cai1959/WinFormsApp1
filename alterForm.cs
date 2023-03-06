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
    public partial class alterForm : Form
    {
        string ID="";
        public alterForm()
        {
            InitializeComponent();
        }
         public alterForm(string pid,string pname,string pspeci,string pnumber)
        {
            InitializeComponent();
            ID=textBox1.Text = pid;
            textBox2.Text = pname;
            textBox3.Text = pspeci;
            textBox4.Text = pnumber;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = $"UPDATE t_product SET pid='{textBox1.Text}' , pname='{textBox2.Text}',pspeci='{textBox3.Text}',pnumber='{textBox4.Text}' WHERE pid='{ID}'";
            Dao dao = new Dao();
            if(dao.Execute(sql)>0) 
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
            dao.Daoclose();
        }
    }
}
