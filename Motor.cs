using System;

public class Motor
{
    public string Merk { get; set; }
    public double HargaTunai { get; set; }
    public double Cicilan { get; set; }
    public double DownPayment { get; set; }
	public Motor()
	{

	}
    public Motor(string merk, string tunai)
    {
        Merk = merk;
        HargaTunai = tunai;
        Cicilan = 0;
        DownPayment = 0;
    }
    public Motor(string merk, string tunai, string cicilan, string dp)
    {
        Merk = merk;
        HargaTunai = tunai;
        Cicilan = cicilan;
        DownPayment = dp;
    }
    public double HargaTotalCicilan()
    {

    }
}
