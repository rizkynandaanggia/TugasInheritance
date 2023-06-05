using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance_Tugas_minggu_8;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Abdul Mizwar", 24);
            person1.InfoPerson();

            // Inheritance
            Karyawan karyawan1 = new Karyawan("Putri", 24, "Dosen");
            karyawan1.InfoPerson();

            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void InfoPerson()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }

    class Karyawan : Person
    {
        public string JobTitle { get; set; }

        public Karyawan(string name, int age, string jobTitle) : base(name, age)
        {
            JobTitle = jobTitle;
        }

        public void InfoPerson()
        {
            base.InfoPerson();
            Console.WriteLine("Job Title: " + JobTitle);
        }
    }
}
