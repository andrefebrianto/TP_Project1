using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Project1
{
    class Motor
    {
        public string id { get; set; }
        public string Merk { get; set; }
        public string Jenis { get; set; }
        public string Model { get; set; }
        public double HargaTunai { get; set; }
        public double HargaKredit { get; set; }
        public Motor()
        {

        }
        public Motor(string merk, double tunai) :
            this(merk,tunai,0){}
        public Motor(string merk, double tunai, double kredit)
        {
            Merk = merk;
            HargaTunai = tunai;
            HargaKredit = kredit;
            
        }
        public static Motor GetDataMotor(string jenis)
        {
            return ExcelHandler.GetDataMotor(jenis);
        }
        public double DP()
        {
            return 10*HargaKredit / 100;
        }
        public double cicilan(double dp, double bulan)
        {
            return (HargaKredit - dp) / bulan;
        }
    }
}
