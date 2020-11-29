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

    public partial class Frm_Product : Form
    {

        public static string Account;  //靜態，存取login畫面中使用者的登入ID
        public static bool isAdmin;    //權限
        public Frm_Product()
        {
            InitializeComponent();
            cmb_dassai.SelectedIndex = 9;  //combobox預設為0
            cmb_beer.SelectedIndex = 9;
            cmb_wine.SelectedIndex = 9;
            cmb_wine.SelectedIndex = 9;
            cmb_syoucyu.SelectedIndex = 9;
            cmb_ume.SelectedIndex = 9;
            cmb_roll.SelectedIndex = 9;
            cmb_kasurera.SelectedIndex = 9;
            cmb_cake.SelectedIndex = 9;
            cmb_choco.SelectedIndex = 9;
            cmb_cookie.SelectedIndex = 9;
            cmb_manjyu.SelectedIndex = 9;

        }
        public void GetAccount(string acc, bool Admin)  //取得登入的使用者帳號
        {
            Account = acc;
            isAdmin = Admin;
            if (!isAdmin) //false刪除管理者畫面(沒有權限看不到)
            {
                tabControl1.TabPages.Remove(管理者畫面);
            }
        }
        Project1Entities3 dbContext = new Project1Entities3();

        private void button13_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://shop.r10s.jp/b-miyoshi/cabinet/dassai/dassai23-1800.jpg";
            pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
        }



        private void button12_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/818MINQQiWL._AC_SL1500_.jpg";
            pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/51c8CR3IRVL._AC_.jpg";
            pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/71VM2NI4jZL._AC_SL1500_.jpg";
            pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Url_dassai = "https://images-na.ssl-images-amazon.com/images/I/71gad5Nmy4L._AC_SL1500_.jpg";
            pictureBox1.Image = Image.FromStream(System.Net.WebRequest.Create(Url_dassai).GetResponse().GetResponseStream());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Url_YOKUMOKU = "https://images-na.ssl-images-amazon.com/images/I/81qDhdD-MXL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_YOKUMOKU).GetResponse().GetResponseStream());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Url_kasutera = "https://images-na.ssl-images-amazon.com/images/I/71i2UXA6C%2BL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_kasutera).GetResponse().GetResponseStream());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Url_kupen = "https://images-na.ssl-images-amazon.com/images/I/91JFDmYBSaL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_kupen).GetResponse().GetResponseStream());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string Url_chocolate = "https://images-na.ssl-images-amazon.com/images/I/51Pu4AQq4PL._AC_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_chocolate).GetResponse().GetResponseStream());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Url_chocolate = "https://images-na.ssl-images-amazon.com/images/I/51%2BzCuv6CkL._AC_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_chocolate).GetResponse().GetResponseStream());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string Url_manjyuu = "https://images-na.ssl-images-amazon.com/images/I/71Ghg6%2Bh1%2BL._AC_SL1500_.jpg";
            PicBox_ProFood.Image = Image.FromStream(System.Net.WebRequest.Create(Url_manjyuu).GetResponse().GetResponseStream());
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            dataGridView_OrderList.DataSource = null;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_PWDreset PWDreset = new Frm_PWDreset();
            PWDreset.Show();
        }



        private void btnOrder_Click(object sender, EventArgs e)
        {
            dataGridView_Cart.Rows.Clear();
            if (int.Parse(cmb_dassai.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("日本酒", int.Parse(cmb_dassai.Text), 2);//商品名稱，數量，ProductID(隱藏)
            }
            if (int.Parse(cmb_beer.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("啤酒", int.Parse(cmb_beer.Text), 3);
            }
            if (int.Parse(cmb_wine.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("紅酒", int.Parse(cmb_wine.Text), 5);
            }
            if (int.Parse(cmb_syoucyu.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("焼酎", int.Parse(cmb_syoucyu.Text), 6);
            }
            if (int.Parse(cmb_ume.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("梅酒", int.Parse(cmb_ume.Text), 7);
            }
            if (int.Parse(cmb_roll.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("捲心酥", int.Parse(cmb_roll.Text), 8);
            }
            if (int.Parse(cmb_kasurera.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("蜂蜜蛋糕", int.Parse(cmb_kasurera.Text), 9);
            }
            if (int.Parse(cmb_cake.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("千層蛋糕", int.Parse(cmb_cake.Text), 11);
            }
            if (int.Parse(cmb_choco.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("巧克力", int.Parse(cmb_choco.Text), 12);
            }
            if (int.Parse(cmb_cookie.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("夾心酥", int.Parse(cmb_cookie.Text), 13);
            }
            if (int.Parse(cmb_manjyu.Text) != 0)
            {
                dataGridView_Cart.Rows.Add("饅頭糕點", int.Parse(cmb_manjyu.Text), 14);
            }
            int amount = int.Parse(cmb_dassai.Text) * 3999 + int.Parse(cmb_beer.Text) * 2400 + int.Parse(cmb_wine.Text) * 2400 + int.Parse(cmb_syoucyu.Text) * 3500 + int.Parse(cmb_ume.Text) * 3000 + int.Parse(cmb_roll.Text) * 120 + int.Parse(cmb_kasurera.Text) * 350 + int.Parse(cmb_cake.Text) * 300 + int.Parse(cmb_choco.Text) * 350 + int.Parse(cmb_cookie.Text) * 450 + int.Parse(cmb_manjyu.Text) * 280;
            lblTotal.Text = $"總金額為 : " + $"{amount} 元";
            MessageBox.Show("成功加入購物車!!!");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            DateTime OrderDate_From = DateTime.Parse(DTP_SF.Value.ToString("yyyy/MM/dd"));
            DateTime OrderDate_End = DateTime.Parse(DTP_SE.Value.ToString("yyyy/MM/dd")).AddDays(1); //搜尋09/21 00:00:00 <= 只會抓到09/20 
            var q = from i in dbContext.OrderLists
                    where i.OrderDate >= OrderDate_From && i.OrderDate <= OrderDate_End && i.MemberID == Account
                    select new { 訂單編號 = i.OrderID, 購買日期 = i.OrderDate };

            dataGridView_OrderList.DataSource = q.ToList();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            try
            {
                //取得在DataGridView中點選到的項目
                int OrderID = int.Parse(dataGridView_OrderList.CurrentRow.Cells[0].Value.ToString());
                var q = from i in dbContext.OrderDetails
                        where i.OrderID == OrderID
                        select new { 產品名稱 = i.ProductList.ProductName, 購買數量 = i.ProductCount };

                dataGridView_Detail.DataSource = q.ToList();

                var totalPrice = from t in dbContext.OrderLists
                                 where t.OrderID == OrderID
                                 select t.TotalPrice;
                //建一個陣列來接totalPrice.ToList()裡面的值才可以取出來
                List<int> Price = totalPrice.ToList();

                lblSearchTotal.Text = $"該筆訂單金額為 : {Price[0]} 元";
            }
            catch (Exception)
            {
                MessageBox.Show("請建立訂單!!!");
            }


        }

        private void btnOrderSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cart.RowCount < 2)
            {
                MessageBox.Show("請選擇商品!");
            }
            else
            {
                //建[OrderList]                     
                OrderList OrderList = new OrderList()
                {
                    MemberID = Account,
                    OrderDate = DateTime.Now,
                    TotalPrice = int.Parse(cmb_dassai.Text) * 3999 + int.Parse(cmb_beer.Text) * 2400 + int.Parse(cmb_wine.Text) * 2400 + int.Parse(cmb_syoucyu.Text) * 3500 + int.Parse(cmb_ume.Text) * 3000 + int.Parse(cmb_roll.Text) * 120 + int.Parse(cmb_kasurera.Text) * 350 + int.Parse(cmb_cake.Text) * 300 + int.Parse(cmb_choco.Text) * 350 + int.Parse(cmb_cookie.Text) * 450 + int.Parse(cmb_manjyu.Text) * 280
                };
                dbContext.OrderLists.Add(OrderList);
                dbContext.SaveChanges();

                //抓此使用者最新OrderID
                var q = from i in dbContext.OrderLists
                        where i.MemberID == Account
                        orderby i.OrderID descending
                        select i;
                int OrderID_latest = q.ToList()[0].OrderID;

                //跑datagridview迴圈，並用上面的OrderID去建[OrderDetail]
                for (int i = 0; i < dataGridView_Cart.Rows.Count - 1; i++)
                {
                    int ProductCount = int.Parse(dataGridView_Cart.Rows[i].Cells[1].Value.ToString());
                    int ProdurctID = int.Parse(dataGridView_Cart.Rows[i].Cells[2].Value.ToString());  //producdID
                    OrderDetail OrderDetail = new OrderDetail()
                    {
                        OrderID = OrderID_latest, //
                        ProductID = ProdurctID,
                        ProductCount = ProductCount
                    };
                    dbContext.OrderDetails.Add(OrderDetail);
                    dbContext.SaveChanges();
                }
                cmb_dassai.SelectedIndex = 9;  //combobox預設為0
                cmb_beer.SelectedIndex = 9;
                cmb_wine.SelectedIndex = 9;
                cmb_wine.SelectedIndex = 9;
                cmb_syoucyu.SelectedIndex = 9;
                cmb_ume.SelectedIndex = 9;
                cmb_roll.SelectedIndex = 9;
                cmb_kasurera.SelectedIndex = 9;
                cmb_cake.SelectedIndex = 9;
                cmb_choco.SelectedIndex = 9;
                cmb_cookie.SelectedIndex = 9;
                cmb_manjyu.SelectedIndex = 9;
                MessageBox.Show("已送出訂單!!!");
            }
        }

        private void btnOrderClear_Click(object sender, EventArgs e)
        {
            dataGridView_Cart.Rows.Clear();
            dataGridView_Cart.DataSource = null;
            lblTotal.Text = "總金額為 :           元";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var name = (from i in dbContext.Members
                        where i.MemberID == Account  //Account為static 從Frm_LogIn取得
                        select i).FirstOrDefault();
            if (txtResetPWD.Text.Contains(" "))
            {
                MessageBox.Show("密碼不可包含空白!");
                txtResetPWD.Text = string.Empty;
            }
            else{
                name.MemberPWD = txtResetPWD.Text;
                MessageBox.Show("密碼修改成功");
                this.dbContext.SaveChanges();
            }

        }

        private void btnCuSearch_Click(object sender, EventArgs e)
        {
            DateTime OrderDate_CusFrom = DateTime.Parse(DTP_adminFrom.Value.ToString("yyyy/MM/dd"));
            DateTime OrderDate_CusEnd = DateTime.Parse(DTP_adminEnd.Value.ToString("yyyy/MM/dd")).AddDays(1); //搜尋09/21 00:00:00 <= 只會抓到09/20 
            var q = from i in dbContext.OrderLists
                    where i.OrderDate >= OrderDate_CusFrom && i.OrderDate <= OrderDate_CusEnd
                    select new { 訂單編號 = i.OrderID, 客戶名稱 = i.MemberID, 訂單日期 = i.OrderDate };

            dataGridView_CustomerID.DataSource = q.ToList();
        }

        private void btnCuOrderlist_Click(object sender, EventArgs e)
        {
            if (dataGridView_CustomerID.CurrentRow == null)
                return;
            int OrderID = int.Parse(dataGridView_CustomerID.CurrentRow.Cells[0].Value.ToString()); //Cells[?]當中輸入的值為欲取得的第幾行的值
            var q = from i in dbContext.OrderDetails
                    where i.OrderID == OrderID
                    select new { 產品名稱 = i.ProductList.ProductName, 購買數量 = i.ProductCount };
            dataGridView_CuOrderlist.DataSource = q.ToList();

            var totalPrice = from t in dbContext.OrderLists
                             where t.OrderID == OrderID
                             select t.TotalPrice;
            //建一個陣列來接totalPrice.ToList()裡面的值才可以取出來
            List<int> Price = totalPrice.ToList();

            lblAdTotalPrice.Text = $"該筆訂單金額為 : {Price[0]} 元";


        }

        private void btnResetOrder_Click(object sender, EventArgs e)
        {
            cmb_dassai.SelectedIndex = 9;  //combobox預設為0
            cmb_beer.SelectedIndex = 9;
            cmb_wine.SelectedIndex = 9;
            cmb_wine.SelectedIndex = 9;
            cmb_syoucyu.SelectedIndex = 9;
            cmb_ume.SelectedIndex = 9;
        }

        private void btnResetF_Click(object sender, EventArgs e)
        {
            cmb_roll.SelectedIndex = 9;
            cmb_kasurera.SelectedIndex = 9;
            cmb_cake.SelectedIndex = 9;
            cmb_choco.SelectedIndex = 9;
            cmb_cookie.SelectedIndex = 9;
            cmb_manjyu.SelectedIndex = 9;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteOrderDe = from d in dbContext.OrderDetails.AsEnumerable()
                                    where d.OrderID == int.Parse(txtdeleteOrder.Text)
                                    select d;

                if (deleteOrderDe == null) return;
                else
                {
                    foreach (var delete in deleteOrderDe)
                    {
                        this.dbContext.OrderDetails.Remove(delete);
                    }
                    this.dbContext.SaveChanges();
                    MessageBox.Show("刪除成功!");
                }
                lblAdTotalPrice.Text = " ";
                var deleteOderID = (from O in dbContext.OrderLists.AsEnumerable()
                                    where O.OrderID == int.Parse(txtdeleteOrder.Text)
                                    select O).FirstOrDefault();
                if (deleteOderID == null) return;
                this.dbContext.OrderLists.Remove(deleteOderID);
                this.dbContext.SaveChanges();

                this.dataGridView_CuOrderlist.DataSource = null;

                DateTime OrderDate_CusFrom = DateTime.Parse(DTP_adminFrom.Value.ToString("yyyy/MM/dd"));
                DateTime OrderDate_CusEnd = DateTime.Parse(DTP_adminEnd.Value.ToString("yyyy/MM/dd")).AddDays(1); //搜尋09/21 00:00:00 <= 只會抓到09/20 
                var q = from i in dbContext.OrderLists
                        where i.OrderDate >= OrderDate_CusFrom && i.OrderDate <= OrderDate_CusEnd
                        select new { 訂單編號 = i.OrderID, 客戶名稱 = i.MemberID, 訂單日期 = i.OrderDate };

                dataGridView_CustomerID.DataSource = q.ToList();

                //Read_RefreshDataGridView();

            }
            catch (Exception)
            {
                MessageBox.Show("請輸入欲刪除的訂單編號!");
            }

        }
        void Read_RefreshDataGridView()
        {
            this.dataGridView_CuOrderlist.DataSource = null;
            this.dataGridView_CuOrderlist.DataSource = this.dbContext.OrderDetails.ToList();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LogIn Restart = new LogIn();
            Restart.Show();
            this.Close();
        }
    }
}
