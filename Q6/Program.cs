using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
	internal class Program
	{
		static void Main(string[] args)
		{//比對使用者輸入值是否為 "Allen", 區分大小寫
			Console.Write("請輸入Allen：");
			string input = Console.ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				Console.WriteLine("您未輸入");
				return;
			}

			if (input == "Allen")
			{
				Console.WriteLine("正確");
			}
			else
			{
				Console.WriteLine("錯誤");
			}
		}
	}
}
