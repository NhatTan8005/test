using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_tour
{
    public partial class frmdangkytaikhoan : Form
    {
        public frmdangkytaikhoan()
        {
            InitializeComponent();
        }
        public string tendangnhap = "";
        public string loaitk = "";
        private void rtxtTAIKHOAN_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtxtMATKHAU_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cbbLOAITK_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmdangkytaikhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if (cbbLOAITK.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if (string.IsNullOrEmpty(rtxtTAIKHOAN.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản! ");
                rtxtTAIKHOAN.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMATKHAUDK.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khảu! ");
                txtMATKHAUDK.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtXACNHANMK.Text))
            {
                MessageBox.Show("Vui lòng nhập xác minh mật khẩu! ");
                txtXACNHANMK.Select();
                return;
            }
            #region SWTK
            tendangnhap = rtxtTAIKHOAN.Text;
            loaitk = "";
            switch (cbbLOAITK.Text)
            {
                case "Quản trị viên ":
                    loaitk = "admin";
                    break;
                case "Nhân Viên ":
                    loaitk = "nhanvien";
                    break;
                case "Khách Hàng ":
                    loaitk = "khachhang";
                    break;
            }
            #endregion
            if (txtXACNHANMK.Text == txtMATKHAUDK.Text)
            {
                List<CustomParameter> lst = new List<CustomParameter>()
                {
                    new CustomParameter()
                    {
                        key = "@LOAITAIKHOAN",
                        value= loaitk
                    },
                    new CustomParameter()
                    {
                        key = "@TAIKHOAN",
                        value= rtxtTAIKHOAN.Text
                    },
                    new CustomParameter()
                    {
                        key = "@MATKHAUDK",
                        value= txtMATKHAUDK.Text
                    },

                };
                var rs = new database().SelectData("DANGKYTAIKHOAN", lst);
                MessageBox.Show("Đăng ký tài khoản thành công");
                rtxtTAIKHOAN.Clear();
                txtMATKHAUDK.Clear();
                txtXACNHANMK.Clear();
            }
            else
            {
                MessageBox.Show("Mật khẩu xác nhận không đúng, xin mời nhập lại !!");
                txtXACNHANMK.Clear();
                txtXACNHANMK.Select();
            }

        }

        private void frmdangkytaikhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát! ", "Xác Nhận thoát !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
