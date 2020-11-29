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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        
        Project1Entities3 dbContext = new Project1Entities3();
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var q = from i in dbContext.Members
                    where i.MemberID == txtAcc.Text && i.MemberPWD == txtPWD.Text
                    select i;
            if (q.Count() == 1)
            {
                MessageBox.Show("登入成功");              
                Frm_Product frm_Product = new Frm_Product();
                frm_Product.GetAccount(txtAcc.Text,q.ToList()[0].IsAdmin);  //將輸入的帳號存入static Account中、isAdmin權限存取
                frm_Product.Show();
                
            }
            else
            {
                MessageBox.Show("登入失敗");
            }
        }

        private void btnFgt_Click(object sender, EventArgs e)
        {
            Forget forget = new Forget();
            forget.Show();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            SingIn singIn = new SingIn();
            singIn.Show();
        }
      
        private void button13_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://shop.r10s.jp/b-miyoshi/cabinet/dassai/dassai23-1800.jpg";
            PicBox_Login.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
            lblDrinkPrice.Text = "NT$3999/瓶";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/818MINQQiWL._AC_SL1500_.jpg";
            PicBox_Login.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
            lblDrinkPrice.Text = "NT$2400/箱";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/51c8CR3IRVL._AC_.jpg";
            PicBox_Login.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
            lblDrinkPrice.Text = "NT$2400/瓶";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/71gad5Nmy4L._AC_SL1500_.jpg";
            PicBox_Login.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
            lblDrinkPrice.Text = "NT$3500/瓶";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/71VM2NI4jZL._AC_SL1500_.jpg";
            PicBox_Login.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
            lblDrinkPrice.Text = "NT$3000/瓶";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Url_YOKUMOKU = "https://images-na.ssl-images-amazon.com/images/I/81qDhdD-MXL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_YOKUMOKU).GetResponse().GetResponseStream());
            lblfoodPrice.Text = "NT$120/盒";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Url_kasutera = "https://images-na.ssl-images-amazon.com/images/I/71i2UXA6C%2BL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_kasutera).GetResponse().GetResponseStream());
            lblfoodPrice.Text = "NT$350/盒";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Url_kupen = "https://images-na.ssl-images-amazon.com/images/I/91JFDmYBSaL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_kupen).GetResponse().GetResponseStream());
            lblfoodPrice.Text = "NT$300/盒";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Url_chocolate = "https://images-na.ssl-images-amazon.com/images/I/51Pu4AQq4PL._AC_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_chocolate).GetResponse().GetResponseStream());
            lblfoodPrice.Text = "NT$350/盒";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Url_chocolate = "https://images-na.ssl-images-amazon.com/images/I/51%2BzCuv6CkL._AC_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_chocolate).GetResponse().GetResponseStream());
            lblfoodPrice.Text = "NT$450/盒";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string Url_manjyuu = "https://images-na.ssl-images-amazon.com/images/I/71Ghg6%2Bh1%2BL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_manjyuu).GetResponse().GetResponseStream());
            lblfoodPrice.Text = "NT$280/盒";
        }

        
    }
}
