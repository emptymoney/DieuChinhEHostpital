using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DieuChinhEHostpital
{
    public partial class MainForm : Form
    {
        public const string CONNSTR = "";
        bool _isFormShow = false;

        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private bool CheckForm(string formName)
        {
            foreach (Form form in MdiChildren)
            {
                if (form.Name.Equals(formName)) return true;
            }
            return false;
        }

        private void saveBenhAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            _isFormShow = CheckForm("SaveBenhAn");
            if (!_isFormShow)
            {
                SaveBenhAn saveBenhAn = new SaveBenhAn();
                saveBenhAn.MdiParent = this;
                saveBenhAn.WindowState = FormWindowState.Maximized;               
                saveBenhAn.Show();
            }
        }

        private void saveSoLePDTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isFormShow = CheckForm("ChinhSoLePDT");
            if (!_isFormShow)
            {
                ChinhSoLePDT chinhSoLePDT = new ChinhSoLePDT();
                chinhSoLePDT.MdiParent = this;
                chinhSoLePDT.WindowState = FormWindowState.Maximized;
                chinhSoLePDT.Show();
            }
        }
    }
}
