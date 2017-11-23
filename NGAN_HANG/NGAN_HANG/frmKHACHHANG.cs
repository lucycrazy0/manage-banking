using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NGAN_HANG
{
    public partial class frmKHACHHANG : Form
    {
        string macn = "";

        int vitri = 0;

        SqlDataReader myReader;

        public frmKHACHHANG()
        {
            InitializeComponent();
        }

        private void kHACHHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmKHACHHANG_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dS.KHACHHANG' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.KHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
            this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
            this.tAIKHOANTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tAIKHOANTableAdapter.Fill(this.DS.TAIKHOAN);
            macn = ((DataRowView)bdsKH[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bdsDSPM;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG") cmbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
            else cmbChiNhanh.Enabled = false;

            gcTAOTAIKHOAN.Enabled = false;

            txtDIACHI.Enabled = false;
            txtTENKH.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            cmbNGAYCAP.Enabled = false;
            cmbPHAI.Enabled = false;
            txtMACN.Enabled = false;

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

            if (cmbChiNhanh.SelectedIndex != Program.mChinhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.KHACHHANGTableAdapter.Connection.ConnectionString = Program.connstr;
                this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
                macn = ((DataRowView)bdsKH[0])["MACN"].ToString();
            }   
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcTAOTAIKHOAN.Enabled = true;
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            vitri = bdsKH.Position;

            txtDIACHI.Enabled = true;
            txtTENKH.Enabled = true;
            txtCMND.Enabled = true;
            txtSDT.Enabled = true;
            cmbNGAYCAP.Enabled = true;
            cmbPHAI.Enabled = true;

            bdsKH.AddNew();
            txtMACN.Text = macn;
            cmbPHAI.SelectedValue = 0;
            btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = false;
            btnGHI.Enabled = btnUNDO.Enabled = true;
            gcKHACHHANG.Enabled = false;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtCMND.Enabled == false && btnSUA.Enabled == false)
            {
                String strLenh = "EXEC SP_UPDATEKHACHHANG N'" + txtTENKH.Text + "' , N'" + txtDIACHI.Text + "' , N'" + txtCMND.Text + "' , N'" + cmbNGAYCAP.Text + "' , N'" + txtSDT.Text + "' , N'" + cmbPHAI.Text + "'";

                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader == null)
                    MessageBox.Show("Sửa thông tin khách hàng không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                txtDIACHI.Enabled = false;
                txtTENKH.Enabled = false;
                txtCMND.Enabled = false;
                txtSDT.Enabled = false;
                cmbNGAYCAP.Enabled = false;
                cmbPHAI.Enabled = false;

                gcKHACHHANG.Enabled = true;

                btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = true;
                btnGHI.Enabled = btnUNDO.Enabled = false;

                try
                {
                    this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                String strLenh = "EXEC SP_THEMKHACHHANG N'" + txtTENKH.Text + "' , N'" + txtDIACHI.Text + "' , N'" + txtCMND.Text + "' , N'" + cmbNGAYCAP.Text + "' , N'" + txtSDT.Text + "' , N'" + cmbPHAI.Text + "' , N'" + txtMACN.Text.Trim() + "'";

                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader == null)
                    MessageBox.Show("Thêm không thành công, trùng CMND", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Thêm thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                txtDIACHI.Enabled = false;
                txtTENKH.Enabled = false;
                txtCMND.Enabled = false;
                txtSDT.Enabled = false;
                cmbNGAYCAP.Enabled = false;
                cmbPHAI.Enabled = false;

                gcKHACHHANG.Enabled = true;

                btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = true;
                btnGHI.Enabled = btnUNDO.Enabled = false;

                try
                {
                    this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnUNDO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {



        }

        private void btnRELOAD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            try
            {
                this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            gcKHACHHANG.Enabled = true;

            txtDIACHI.Enabled = false;
            txtTENKH.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            cmbNGAYCAP.Enabled = false;
            cmbPHAI.Enabled = false;

            gcTAOTAIKHOAN.Enabled = false;
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gcKHACHHANG.Enabled = false;
            txtDIACHI.Enabled = true;
            txtTENKH.Enabled = true;
            txtCMND.Enabled = false;
            txtSDT.Enabled = true;
            cmbNGAYCAP.Enabled = true;
            cmbPHAI.Enabled = true;

            btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = btnTHOAT.Enabled = false;
            btnGHI.Enabled = btnUNDO.Enabled = true;

        }

        private void btnTAOTAIKHOAN_Click(object sender, EventArgs e)
        {
            String strLenh = "EXEC SP_THEMTAIKHOAN N'" + txtSOTK.Text + "' , N'" + cmbCMND.Text + "' , N'" + spSODU.Text + "' , N'" + cmbMACN.Text + "'";

            myReader = Program.ExecSqlDataReader(strLenh);

            if (myReader == null)
                MessageBox.Show("Thêm tài khoản khách hàng không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Thêm tài khoản khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            txtDIACHI.Enabled = false;
            txtTENKH.Enabled = false;
            txtCMND.Enabled = false;
            txtSDT.Enabled = false;
            cmbNGAYCAP.Enabled = false;
            cmbPHAI.Enabled = false;

            gcKHACHHANG.Enabled = true;

            btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = true;
            btnGHI.Enabled = btnUNDO.Enabled = false;

            try
            {
                this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
                this.tAIKHOANTableAdapter.Fill((this.DS.TAIKHOAN));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            gcTAOTAIKHOAN.Enabled = false;

        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
            MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                vitri = bdsKH.Position;

                String CMND = ((DataRowView)bdsKH[vitri])["CMND"].ToString();
                //MessageBox.Show(CMND);
                String strLenh = "EXEC SP_XOAKH '" + CMND + "'";

                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader == null)
                    MessageBox.Show("Xóa tài khoản khách hàng không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Xóa tài khoản khách hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Program.conn.Close();
                    myReader.Close();
                }

                gcKHACHHANG.Enabled = true;

                btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = true;
                btnGHI.Enabled = btnUNDO.Enabled = false;

                try
                {
                    this.KHACHHANGTableAdapter.Fill(this.DS.KHACHHANG);
                    this.tAIKHOANTableAdapter.Fill((this.DS.TAIKHOAN));

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }
    }
}
