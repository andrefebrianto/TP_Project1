using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TP_Project1
{
    public partial class frmMain : MetroForm
    {
        private Pembeli buyer;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lvDaftarCicilan.View = View.Details;
            lvDaftarCicilan.Columns.Add("Down Payment",110);
            lvDaftarCicilan.Columns.Add("12 Bulan", 110);
            lvDaftarCicilan.Columns.Add("24 Bulan", 110);
            lvDaftarCicilan.Columns.Add("36 Bulan", 110);
            lvDaftarCicilan.Columns.Add("48 Bulan", 110);
        }
    }
}
