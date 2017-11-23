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
    public partial class frmRUTTIEN : Form
    {
        string macn = "";
        int vitri;
        private int ret;
        public frmRUTTIEN()
        {
            SqlConnection conn;
            InitializeComponent();
        }
        public int Ma()
        {
            int result;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SP_LAYLASTMAGD";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MAGD1", SqlDbType.Int).Direction = ParameterDirection.Output;
            //cmd.Parameters.Add("@VALUE", SqlDbType.NChar, 😎.Direction = ParameterDirection.Output;
            result = Program.ExecuteReader(cmd);
            int kq = Convert.ToInt16(cmd.Parameters["@MAGD1"].Value);
            return kq;
        }
        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGDGUIRUTTIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmRUTGUITIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GD_GOIRUT' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.GD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            cmbChiNhanh.DataSource = Program.bdsDSPM;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChinhanh;
            cmbChiNhanh.Enabled = false;

            txtMAGD.Enabled = false;
            txtMANV.Enabled = false;
            txtSOTK.Enabled = false;
            txtSOTIEN.Enabled = false;
            cmbLOAIGD.Enabled = false;
            dateNGAYGD.Enabled = false;


            int magd = Ma();
            MessageBox.Show(magd + "");

            SqlDataReader myReader;
            
            if (Program.KetNoi() == 0) return;

           /* String strLenh = "EXEC SP_LAYLASTMAGD";

            myReader = Program.ExecSqlDataReader(strLenh);
            if (myReader == null) return;

            myReader.Read();*/

         //   MessageBox.Show(myReader.GetString(0));
            //try {
            //    int maGD=0;
            //    String str_Lenh = "EXEC SP_LAYLASTMAGD '" + maGD + "'";
            //    myReader = Program.ExecSqlDataReader(str_Lenh);

            //    if (myReader == null) return;
            //    myReader.Read();
            //    ret = myReader.RecordsAffected;
            //    MessageBox.Show(ret+"sdsdsd");
            //    myReader.Close();
            //    if (ret == -1)
            //    {
            //        MessageBox.Show("Loi sp");
            //    }
            //    else if (ret != -1)
            //    {
            //        MessageBox.Show("THANH CONG" + ret );

            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Loi" + ex.Message);
            //}
           

           // myReader.Close();
            Program.conn.Close();
        }

        private void gD_GOIRUTGridControl_Click(object sender, EventArgs e)
        {

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsGDGUIRUTTIEN.Position;

            gcGDGOIRUTTIEN.Enabled = false;
            txtMAGD.Enabled = true;
            txtMANV.Enabled = true;
            txtSOTK.Enabled = true;
            txtSOTIEN.Enabled = true;
            cmbLOAIGD.Enabled = true;
            dateNGAYGD.Enabled = true;

            bdsGDGUIRUTTIEN.AddNew();
            btnTHEM.Enabled = btnSUA.Enabled = btnXOA.Enabled = btnRELOAD.Enabled = false;
            btnGHI.Enabled = btnPHUCHOI.Enabled = true;
        }

    }
}
