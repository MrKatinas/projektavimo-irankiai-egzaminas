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
		public string Name;
		private int Age;

		public void Add() { }
	}

	public class Student : Person
	{
		public double GPA;
		private List<VisibilityNotation> visibilityNotations;

		public void Study(double howLong) { }

		public Student()
		{
			this.visibilityNotations = new List<VisibilityNotation>();
		}

		public Student(List<VisibilityNotation> visibilityNotations)
		{
			this.visibilityNotations = visibilityNotations;
		}
	}

	public class VisibilityNotation
	{
		public void PrivateMethod() { }
		private void PublicMethod() { }
		protected void ProtectedMethod() { }
		//abstract void AbstractMethod();
		public static void StaticMethod() { }
	}

	public class Faculty
	{
		public string Name;
		public List<Student> Students;
	}

	public class University
	{
		public string Title;
		public Faculty[] Faculties;

		public Student GetStudent(int studentId)
		{
			return new Student();
		}
	}
}
