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
    public partial class frmNHANVIEN : Form
    {

        int vitri = 0;
        string macn = "";
        SqlDataReader myReader;
        public frmNHANVIEN()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;

            txtDIACHI.Enabled = true;
            cmbMACN.Enabled = true;
            txtMANV.Enabled = true;
            txtSDT.Enabled = true;
            txtTENNV.Enabled = true;
            cmbPHAI.Enabled = true;

            bdsNV.AddNew();
            cmbMACN.Text = macn;
            cmbPHAI.SelectedValue = 0;
            btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = false;
            btnGHI.Enabled = btnUNDO.Enabled = true;
            gcNHANVIEN.Enabled = false;
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmNHANVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.NHANVIEN' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
            macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            cmbChiNhanh.DataSource = Program.bdsDSPM;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            if (Program.mGroup == "NGANHANG") cmbChiNhanh.Enabled = true;  // bật tắt theo phân quyền
            else cmbChiNhanh.Enabled = false;

            txtDIACHI.Enabled = false;
            cmbMACN.Enabled = false;
            txtMANV.Enabled = false;
            txtSDT.Enabled = false;
            txtTENNV.Enabled = false;
            cmbPHAI.Enabled = false;
            btnGHI.Enabled = false;
        }


        private void cmbChiNhanh_SelectedIndexChanged_1(object sender, EventArgs e)
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
                this.NHANVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);
                macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }   
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            if (txtTENNV.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được thiếu!", "", MessageBoxButtons.OK);
                txtTENNV.Focus();
                return;
            }

            if (cmbMACN.Enabled == false && btnSUA.Enabled == false && txtMANV.Enabled == false)
            {
                String strLenh = "EXEC SP_UPDATENHANVIEN N'" + txtTENNV.Text + "' , N'" + txtDIACHI.Text + "' , N'" + txtMANV.Text + "' , N'" + cmbPHAI.Text + "' , N'" + txtSDT.Text + "' , N'" + cmbMACN.Text.Trim() + "'";

                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader == null)
                    MessageBox.Show("Hiệu chỉnh nhân viên không thành công, trùng mã NV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Hiệu chỉnh nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Program.conn.Close();
                    myReader.Close();
                }      
            }
            else
            {
                // Kiểm tra MACN, PHAI, NGAYSINH  phải có
                // LUONg thỏa Miền giá trị
                // MANV không được trùng trên các phân mảnh

                String strLenh = "EXEC SP_THEMNHANVIEN N'" + txtTENNV.Text + "' , N'" + txtDIACHI.Text + "' , N'" + txtMANV.Text + "' , N'" + cmbPHAI.Text + "' , N'" + txtSDT.Text + "' , N'" + cmbMACN.Text.Trim() + "'";

                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader == null)
                    MessageBox.Show("Thêm nhân viên không thành công, trùng mã NV", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Program.conn.Close();
                    myReader.Close();
                }   

            }
            try
            {
                this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNHANVIEN.Enabled = true;
            btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = true;
            btnGHI.Enabled = btnUNDO.Enabled = false;

            gcNHANVIEN.Enabled = true;

            txtDIACHI.Enabled = false;
            cmbMACN.Enabled = false;
            txtMANV.Enabled = false;
            txtSDT.Enabled = false;
            txtTENNV.Enabled = false;
            cmbPHAI.Enabled = false;
            btnGHI.Enabled = false;
        }

        private void btnUNDO_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();
            if (btnTHEM.Enabled == false) bdsNV.Position = vitri;
            gcNHANVIEN.Enabled = true;

            txtDIACHI.Enabled = false;
            cmbMACN.Enabled = false;
            txtMANV.Enabled = false;
            txtSDT.Enabled = false;
            txtTENNV.Enabled = false;
            cmbPHAI.Enabled = false;
            btnGHI.Enabled = false;

            btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = btnTHOAT.Enabled = true;
            btnGHI.Enabled = btnUNDO.Enabled = false;
        }

        private void btnXOA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                vitri = bdsNV.Position;

                String MANV = ((DataRowView)bdsNV[vitri])["MANV"].ToString();
                //MessageBox.Show(CMND);
                String strLenh = "EXEC SP_XOANV N'" + MANV + "'";

                myReader = Program.ExecSqlDataReader(strLenh);

                if (myReader == null)
                    MessageBox.Show("Xóa nhân viên không thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                    Program.conn.Close();
                    myReader.Close();
                }

                gcNHANVIEN.Enabled = true;

                btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = true;
                btnGHI.Enabled = btnUNDO.Enabled = false;

                try
                {
                    this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnSUA_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;

            txtDIACHI.Enabled = true;
            cmbMACN.Enabled = false;
            txtMANV.Enabled = false;
            txtSDT.Enabled = true;
            txtTENNV.Enabled = true;
            cmbPHAI.Enabled = true;

            btnTHEM.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = true;
            btnSUA.Enabled = false;
            btnGHI.Enabled = btnUNDO.Enabled = true;
            gcNHANVIEN.Enabled = false;
        }

        private void btnRELOAD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.NHANVIENTableAdapter.Fill(this.DS.NHANVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Reload :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.NHANVIENTableAdapter.FillBy(this.DS.NHANVIEN);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
