using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
	internal class Program
	{
		static void Main(string[] args)
		{//隱藏手機的資訊 呈現 0935****46
			string phone = "0935666646";
			string fourNumber = phone.Substring(0, 4);
			string lastTwoNumber=phone.Substring(8);
			string phoneNumber = $"{phone.Substring(0, 4)}{new string('*', 4)}{phone.Substring(8)}";
			Console.WriteLine(phoneNumber);
		}
	}
}
