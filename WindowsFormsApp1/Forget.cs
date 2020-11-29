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
    public partial class Forget : Form
    {
        public Forget()
        {
            InitializeComponent();
        }

        Project1Entities3 dbContext = new Project1Entities3();
        private void btnSub_Click(object sender, EventArgs e)
        {
            DateTime birth = DateTime.Parse(dateTimePicker_birth.Value.ToString("yyyy/MM/dd"));

            var q = from i in dbContext.Members
                    where i.MemberID == txtAcc.Text && i.Birth == birth
                    select i;
            if (q.Count() == 1)
            {
                MessageBox.Show($"Success\nYour PassWord is [ {q.ToList()[0].MemberPWD} ]");
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }  
    }
}
