using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm_PWDreset : Form
    {
        public Frm_PWDreset()
        {
            InitializeComponent();
        }
        public static string Account;
        public void GetAccount(string acc)  //取得登入的使用者帳號
        {
            Account = acc;
        }
        Project1Entities3 dbcontext = new Project1Entities3();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var name = (from i in dbcontext.Members
                       where i.MemberID == Account
                       select i).FirstOrDefault();

            //if (name == null)
            //{
            //    MessageBox.Show("帳號錯誤");
            //}
            //else
            //{
                MessageBox.Show("密碼修改成功");
                name.MemberPWD = txtResetPWD.Text;
                this.dbcontext.SaveChanges();
            //}


            //var name = (from i in dbcontext.Members
            //           where i.MemberID == txtAcc.Text
            //           select i).FirstOrDefault();
            
            //if (name == null)
            //{
            //    MessageBox.Show("帳號錯誤");
            //}
            //else
            //{
            //    MessageBox.Show("密碼修改成功");
            //    name.MemberPWD = txtResetPWD.Text;
            //    this.dbcontext.SaveChanges();
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
