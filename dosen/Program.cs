using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dosen
{
    class Program
    {
        static void Main(string[] args)
        {
            dosen dosen = new dosen();

            Console.WriteLine("Default dosen pengampu: ");
            dosen.display();

            Console.WriteLine("\nMasukan Nama Dan Nik Dosen Baru:");
            dosen.attdosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            dosen.display();

            Console.WriteLine("\nMasukan Mata Kuliah Baru:");
            dosen.addcourse(Console.ReadLine());
            dosen.display();

            Console.ReadLine();
        }
    }
}
