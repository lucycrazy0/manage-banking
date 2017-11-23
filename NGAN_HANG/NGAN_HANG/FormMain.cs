using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NGAN_HANG
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }
        }

        public void HienThiMenu()
        {
            MANV.Text = "Mã NV: " + Program.username + " -";
            HOTEN.Text = "Họ tên nhân viên: " + Program.mHoten + " -";
            NHOM.Text = "Nhóm: " + Program.mGroup;
            // Phân quyền
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void btnNHANVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0)
            {
                btnNHANVIEN.Enabled = false;
            }   
            else
            {
                Form frm = this.CheckExists(typeof(frmNHANVIEN));
                if (frm != null) frm.Activate();
                else
                {
                    frmNHANVIEN f = new frmNHANVIEN();
                    f.MdiParent = this;
                    f.Show();
                }
            }
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.KetNoi() == 0)
                btnKHACHHANG.Enabled = false;
            else
            {
                Form frm = this.CheckExists(typeof(frmKHACHHANG));
                if (frm != null) frm.Activate();
                else
                {
                    frmKHACHHANG f = new frmKHACHHANG();
                    f.MdiParent = this;
                    f.Show();
                }
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmRUTTIEN));
            if (frm != null) frm.Activate();
            else
            {
                frmRUTTIEN f = new frmRUTTIEN();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmCHUYENTIEN));
            if (frm != null) frm.Activate();
            else
            {
                frmCHUYENTIEN f = new frmCHUYENTIEN();
                f.MdiParent = this;
                f.Show();
            }

        }

    }
}
