using System;
using System.Data;
using System.Windows.Forms;

using Framework.Base;
using Framework.Helper;

namespace DieuChinhEHostpital
{
    public partial class SaveBenhAn : Form
    {        
        DataSet _ds = null;
        public SaveBenhAn()
        {
            InitializeComponent();
        }

        private void bShow_Click(object sender, EventArgs e)
        {
            DacHelper dacHelper = new DacHelper(MainForm.CONNSTR);
            _ds = dacHelper.ExecuteQuery("sp_CUST_BenhAnKhuAKhongDongBoLenCenter", null, null);

            if (_ds != null)
            {
                if (_ds.Tables[0].Rows.Count != 0)
                    bFix.Enabled = true;
                else
                    bFix.Enabled = false;

                ultraGrid1.DataSource = _ds.Tables[0];
            }
            else
            {
                bFix.Enabled = false;
            }
        }

        private void bFix_Click(object sender, EventArgs e)
        {
            if (_ds != null && _ds.Tables[0].Rows.Count != 0)
            {
                DacHelper dacHelper = new DacHelper(MainForm.CONNSTR);

                DataSet ds = null;
                try
                {
                    ds = dacHelper.ExecuteQuery("sp_CUST_Sync_BenhAnKhuALenCenter", null, null);
                    bShow_Click(sender, e);
                    MessageBox.Show("Xong");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu");
            }
        }
    }
}
