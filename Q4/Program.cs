using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
	internal class Program
	{
		static void Main(string[] args)
		{//假設有表示日期的字串"1100225", 請將它轉成表示西元年的日期"20210225"
			string Date = "1100225";
			string DateYear = Date.Substring(0, 3);
			string DateMonth = Date.Substring(3, 2);
			string DateDay = Date.Substring(5, 2);
			int DateYearInt = Convert.ToInt32(DateYear);
			int DateYear1911= DateYearInt+1911;
			Console.WriteLine($"{DateYear1911.ToString()}{DateMonth}{DateDay}");




		}
	}
}
