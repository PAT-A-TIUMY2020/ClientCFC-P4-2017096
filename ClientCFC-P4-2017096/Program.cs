using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using ServiceMtk_P2_096;

namespace ClientCFC_P4_2017096
{
	class Program
	{
		static void Main(string[] args)
		{
			BasicHttpBinding bind = new BasicHttpBinding();
			ChannelFactory<IMatematika> objChannel = new
		   ChannelFactory<IMatematika>(bind, "http://localhost:1907");
			IMatematika obj = objChannel.CreateChannel();
			double hasilTambah = obj.Tambah(1, 2);
			Console.WriteLine("1 + 2 = " + hasilTambah);
			double hasilKurang = obj.Kurang(3, 2);
			Console.WriteLine("3 - 2 = " + hasilKurang);
			double hasilKali = obj.Kali(2, 2);
			Console.WriteLine("2 x 2 = " + hasilKali);
			double hasilBagi = obj.Bagi(2, 2);
			Console.WriteLine("2 / 2 = " + hasilBagi);
			Console.ReadLine();
			//Koordinat objk = new Koordinat();
		}
	}
}
