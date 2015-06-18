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
            cmbMerk.DataSource = ExcelHandler.GetListMerkMotor();
        }

        private void cmbMerk_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbJenis.DataSource = ExcelHandler.GetListMotor((string)cmbMerk.SelectedItem);
        }

        private void cmbJenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            Motor motor = Motor.GetDataMotor(cmbMerk.Text);
            lblHargaCash.Text = motor.HargaTunai.ToString();
            
        }

        private void metroRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pnlNama.Visible = true;
            pnlTanggal.Visible = false;
        }

        private void metroRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pnlTanggal.Visible = true;
            pnlNama.Visible = false;
        }
    }
}
