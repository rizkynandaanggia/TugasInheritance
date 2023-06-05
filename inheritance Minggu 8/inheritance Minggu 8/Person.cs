using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_Tugas_minggu_8
{
    public class Person
    {
        // property
        public string Name { get; set; }
        public int Age { get; set; }

        // fungsi
        public void InfoPerson()
        {
            Console.WriteLine("Nama Saya {0}, dan umur saya {1}, tahun", Name, Age);
        }
    }
    // class turunan
    public class karyawan : Person
    {
        // property class karyawan : Person
        public string karyawanID { get; set; }
        public string subject { get; set; }

        //overfride method
        public void InfoPerson(string subject)
        {
            //this
            this.subject = subject;
            Console.WriteLine("Nama Saya {0}, dan umur saya {1}, tahun", this.subject);
        }
    }
}