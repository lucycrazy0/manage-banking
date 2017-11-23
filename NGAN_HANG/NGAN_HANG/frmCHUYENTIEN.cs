using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NGAN_HANG
{
    public partial class frmCHUYENTIEN : Form
    {
        public frmCHUYENTIEN()
        {
            InitializeComponent();
        }

        private void frmCHUYENTIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.GD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.GD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);

        }

        private void btnTHEM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
