using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            Mahasiswa Mahasiswa = new Mahasiswa();
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();
            Console.Write("NIM: ");
            Mahasiswa.Nim = Console.ReadLine();
            Console.Write("Nama: ");
            Mahasiswa.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            Mahasiswa.JenisKelamin = Console.ReadLine().ToUpper() == "L" ? "Laki-Laki" : "Perempuan";
            Console.Write("IPK : ");
            Mahasiswa.Ipk = Console.ReadLine();

            daftarMahasiswa.Add(Mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("No\tNIM\tNama \tJenis Kelamin\tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.Nim, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.Ipk);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
