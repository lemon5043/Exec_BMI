using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_BMI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入身高(公分)");
			string input1 = Console.ReadLine();
			bool isDouble1 = double.TryParse(input1, out double yourHeight);

			Console.WriteLine("請輸入體重(公斤)");
			string input2 = Console.ReadLine();
			bool isDouble2 = double.TryParse(input2, out double yourWeight);

			if (!isDouble1 || yourHeight <= 0 || yourHeight > 300)
			{
				Console.WriteLine("請輸入正確的身高");
			} else if (!isDouble2 || yourWeight <= 0 || yourWeight > 600)
			{
				Console.WriteLine("請輸入正確的體重");
			}

			double yourBMI = calculateBMI(yourHeight, yourWeight);

			Console.WriteLine($"您的BMI為{yourBMI}");
		}

		static double calculateBMI(double h, double w)
		{
			double height = h / 100;

			return (w / (height * height));
		}
	}
}
