using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Project1
{
    class Motor
    {
        public string Merk { get; set; }
        public double HargaTunai { get; set; }
        public double Cicilan { get; set; }
        public double DownPayment { get; set; }
        public Motor()
        {

        }
        public Motor(string merk, double tunai) :
            this(merk,tunai,0,0){}
        public Motor(string merk, double tunai, double cicilan, double dp)
        {
            Merk = merk;
            HargaTunai = tunai;
            Cicilan = cicilan;
            DownPayment = dp;
        }
        public static Motor GetDataMotor()
        {
            return null;
        }
        public double HargaTotalCicilan()
        {
            return 0;
        }
    }
}
