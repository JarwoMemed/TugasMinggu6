using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosen
{
    class dosen
    {
        private int id, Nik;
        private string nama, gender, course;
    
        public dosen()
        {
            this.id = 1;
            this.Nik = 123456789;
            this.nama = "Dosen Pengampu";
            this.gender = "Male";
            this.course = "Pemrograman Berorientasi Objek";
        }
        public void attdosen(string nama, int Nik)
        {
            this.nama = nama;
            this.Nik = Nik;

             
        }

        public void addcourse(string newcourse)
        {
            course += ", " + newcourse;
        }

        public void display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Nama: " + nama);
            Console.WriteLine("NIK: " + Nik);
            Console.WriteLine("gender: " + gender);
            Console.WriteLine("course: " + course);
        }
    }
}
