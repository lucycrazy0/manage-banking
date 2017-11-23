using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace NGAN_HANG
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nGANHANGDataSet.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.nGANHANGDataSet.V_DS_PHANMANH);
            tENCNComboBox.SelectedIndex = 1;
            tENCNComboBox.SelectedIndex = 0;
        }

        private void tENCNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tENCNComboBox.SelectedValue != null)
                Program.servername = tENCNComboBox.SelectedValue.ToString();

        }

        private void mANVLabel_Click(object sender, EventArgs e)
        {

        }
        private void nHANVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim() == "")
            {
                MessageBox.Show(" Bạn chưa nhập tên đăng nhập ", " Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();
                return;
            }
            else if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show(" Bạn chưa nhập mật khẩu ", " Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtTenDangNhap.Focus();
                return;
            }

            Program.username = txtTenDangNhap.Text;
            Program.password = txtPassword.Text;
            Program.mlogin = txtTenDangNhap.Text;
            Program.password = txtPassword.Text;

            if (Program.KetNoi() == 0) return;

            Program.mChinhanh = tENCNComboBox.SelectedIndex;
            Program.bdsDSPM = bdsDSPM;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            SqlDataReader myReader; // 

            String strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;

           
            myReader.Read(); //  trả về true là đọc thành công / hết !  trả về false là chưa đọc hết
            Program.username = myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login Đăng nhập không có quyền truy cập CSDL!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.mHoten = myReader.GetString(1);
            Program.mGroup = myReader.GetString(2);
            //MessageBox.Show("Mã nhân viên : " + Program.username + " - Họ tên : " + Program.mHoten + "  - Nhóm : " + Program.mGroup, "", MessageBoxButtons.OK);
            myReader.Close();
            Program.conn.Close();
            Program.frmChinh.MANV.Text = "Mã NV = " + Program.username;
            Program.frmChinh.HOTEN.Text = "Họ tên = " + Program.mHoten;
            Program.frmChinh.NHOM.Text = "Nhóm = " + Program.mGroup;
            Program.frmChinh.HienThiMenu();
            MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK);
            btnDangNhap.Enabled = false;

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
