using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Employee
{
    class Employee
    {
		internal string name;
		internal long salary;

		public void IncreaseSalary(long sum)
		{
			salary += sum;
		}
		public Employee(string name, long salary)
		{
			this.name = name;
			this.salary = salary;
		}
		public Employee(string name) : this(name, 250000)
		{
		}
		public override string ToString()
		{
			return "Név: " + name + ", Fizetés: " + salary;
		}
	public string DisplayInfo()
		{
			return "Name: " + name + ", Salary: " + salary;
		}
	}
}
