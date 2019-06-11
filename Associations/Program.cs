using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Associations
{
	class Program{static void Main(string[] args){}}

	public class Person
	{
		private string name;
		private string lastName;

		public void add() { }
	}

	public class Professor : Person
	{
		private string salary;

		public void changeSalary() { }
	}
}
