using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{//將字串 "aLLeN kUO" 轉換成 "Allen Kuo"
			string name = "aLLen kUO";
			string nameLower=name.ToLower();

			string firstName = nameLower.Substring(0, 1);

			string lastName = nameLower.Substring(6, 1);
			string lastNameOneUppeer = lastName.ToUpper();

			string answer = $"{firstName.ToUpper()}{nameLower.Substring(1, 5)}{lastName.ToUpper()}{nameLower.Substring(7)}";
			Console.WriteLine(answer);
		}
	}
}
