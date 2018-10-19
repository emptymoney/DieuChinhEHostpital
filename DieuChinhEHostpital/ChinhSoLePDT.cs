using System;
using System.Windows.Forms;
using System.Data;
using Framework.Base;
using Framework.Helper;
using Infragistics.Win.UltraWinGrid;
using System.Data.SqlClient;

namespace DieuChinhEHostpital
{
    public partial class ChinhSoLePDT : Form
    {
        public const string CONNSTR = "";
        

        public ChinhSoLePDT()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            ultraGrid1.DataSource = ultraDataSource1;
        }

        private void txtSoBenhAn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            DacHelper dacHelper = new DacHelper(CONNSTR);
            DataSet ds = null;

            string soBenhAn = txtSoBenhAn.Text;
            ds = dacHelper.ExecuteQuery("sp_CUST_DieuChinhSoLe_PhieuDieuTri"
                , new string[] { "@ACTIONID", "@SoBenhAn"},new object[] { "Select", soBenhAn });
            
            if (ds != null)
            {
                ultraGrid1.DataSource = ds.Tables[0];
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            UltraGridCell cell = ultraGrid1.ActiveCell;
            cell.Row.Selected = true;
            ultraGrid1.UpdateData();
            ultraGrid1.PerformAction(UltraGridAction.ExitEditMode);

            UltraGridRow row = ultraGrid1.Selected.Rows[0];

            if (row != null)
            {                                              
                string chungTu = row.Cells[9].Value.ToString();

                if(chungTu!=string.Empty)
                {
                    MessageBox.Show("Đã có chứng từ, không thể update");
                    return;
                }
                else
                {
                    int toaThuocID = int.Parse(row.Cells[0].Value.ToString());
                    decimal soLuong = decimal.Parse(row.Cells[3].Value.ToString());

                   
                    DataTable table = new DataTable();
                    DataSet dsUpdate = new DataSet();

                    table.Columns.Add("ToaThuoc_id", typeof(int));
                    table.Columns.Add("SoLuong", typeof(decimal));
                    DataRow r = table.NewRow();
                    r["ToaThuoc_id"] = toaThuocID;
                    r["SoLuong"] = soLuong;
                    table.Rows.Add(r);
                    table.Rows[0].AcceptChanges();
                    table.Rows[0].SetModified();
                    dsUpdate.Merge(table);

                    DacHelper dacHelper = new DacHelper(CONNSTR);
                    SqlTransaction trans = dacHelper.BeginTransaction();

                    string soBenhAn = txtSoBenhAn.Text;
                    bool saveOK = false;

                    try
                    {
                        saveOK = dacHelper.ExecuteUpdateData(dsUpdate, "sp_CUST_DieuChinhSoLe_PhieuDieuTri"
                            , new string[] { "@ToaThuoc_id", "@SoLuong" }
                            , dsUpdate.Tables[0].TableName, trans);
                    }
                    catch
                    {
                        saveOK = false;
                    }
                    finally
                    {
                        if (trans != null)
                        {
                            if (saveOK)
                            {
                                trans.Commit();
                                ClearData();
                                MessageBox.Show("Đã update");
                            }
                            else
                            {
                                trans.Rollback();
                                MessageBox.Show("Update thất bại");
                            }

                            trans.Dispose();
                        }

                        trans = null;
                    }
                }
            }
        }

        private void ultraGrid1_AfterExitEditMode(object sender, EventArgs e)
        {

        }
    }
}
