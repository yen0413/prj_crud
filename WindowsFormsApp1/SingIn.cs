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
    public partial class SingIn : Form
    {
        public SingIn()
        {
            InitializeComponent();
        }
        Project1Entities3 dbContext = new Project1Entities3();
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var q = from m in dbContext.Members
                    where m.MemberID == txtAcc.Text
                    select m;
            if (txtAcc.Text.Contains(" "))
            {
                MessageBox.Show("帳號不可包含空格!");
                txtAcc.Text = string.Empty;
            }
            else if (txtPWD.Text.Contains(" "))
            {
                MessageBox.Show("密碼不可包含空格!");
                txtPWD.Text = string.Empty;
            }
            else if (txtUserName.Text.Contains(" "))
            {
                MessageBox.Show("名稱不可包含空格!");
                txtUserName.Text = string.Empty;
            }
            else
            {
                if (q.Count() == 0)
                {
                    Member member = new Member()
                    {
                        MemberID = txtAcc.Text,
                        MemberPWD = txtPWD.Text,
                        MemberName = txtUserName.Text,
                        Birth = DateTime.Parse(dateTimePicker_Birth.Value.ToString("yyyy/MM/dd")),
                        IsAdmin = false,
                        CreateDate = DateTime.Today
                    };
                    dbContext.Members.Add(member);
                    dbContext.SaveChanges();
                    MessageBox.Show("創建成功!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("無效帳號");
                }
            }




        }
    }
}
