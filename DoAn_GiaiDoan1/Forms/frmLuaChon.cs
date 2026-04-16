using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmLuaChon : Form
    {
        public string LuaChon { get; private set; } = "";
        public frmLuaChon()
        {
            InitializeComponent();
        }

        private void btnDongPhong_Click(object sender, EventArgs e)
        {
            LuaChon = "DongPhong";
            this.DialogResult = DialogResult.OK;
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            LuaChon = "ThemDV";
            this.DialogResult = DialogResult.OK;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LuaChon = "Huy";
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
