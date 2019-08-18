using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugWeek1Demo
{
	public class ClassicPerson
	{
		// internal properties
		private string FirstName;
		private string LastName;
		private int Age;
		private string[] Emails;

		// constructor
		public ClassicPerson(string firstName, string lastName, int age)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
		}

		// accessors (setters)
		public string GetFirstName()
		{
			return FirstName;
		}

		public string GetLastName()
		{
			return LastName;
		}

		public int GetAge()
		{
			return Age;
		}

		public string[] GetEmails()
		{
			return Emails;
		}

		// mutators (setters)
		public void SetFirstName(string firstName)
		{
			FirstName = firstName;
		}

		public void SetLastName(string lastName)
		{
			LastName = lastName;
		}
		public void SetAge(int age)
		{
			Age = age;
		}
		public void SetEmails(string[] emails)
		{
			Emails = emails;
		}

		// methods
		public string GetFullName()
		{
			return $"{FirstName} {LastName}";
		}
	}

	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int? Age { get; set; }
		public string[] Emails { get; set; }
		public virtual string GetFullName(bool capitalised = false) {
			if (capitalised) return $"Person name = {FirstName.ToUpper()} {LastName.ToUpper()}";
			return $"Peron name = {FirstName} {LastName}";
		}
	}

	public interface IExportable
	{
		string Export();
	}

	public class Student : Person
	{
		public int StudentId { get; set; }

		override
		public string GetFullName(bool capitalised)
		{
			return $"Student name = {FirstName} {LastName}";
		}
	}

	public interface ITeachable
	{
		string Teach();
	}

	public class Lecturer : Person, IExportable, ITeachable
	{
		public int StaffId { get; set; }
		public string Export()
		{
			return $"{StaffId}";
		}
		public string Teach()
		{
			return "I'm teaching";
		}

		override
		public string GetFullName(bool capitalised)
		{
			return $"Lecturer name = {FirstName} {LastName}";
		}

	}


}
