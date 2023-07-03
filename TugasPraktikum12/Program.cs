using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPraktikum12
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrNim = { 1234, 1235, 1235 };
			string[] arrNama = { "Erik", "Wely", "Sony" };
			int[] arrNilai = { 75, 80, 95 };

			Console.WriteLine("No.      Nim      Nama      Nilai");
			Console.WriteLine("=================================");

			for (int i = 0; i < arrNama.Length; i++)
			{
				Console.WriteLine("{0}.      {1}      {2}       {3}", i + 1, arrNim[i], arrNama[i], arrNilai[i]);
			}

			Console.ReadKey();
		}
	}
}
