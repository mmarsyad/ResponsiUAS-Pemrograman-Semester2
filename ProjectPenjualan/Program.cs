using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");

            // PERINTAH: lengkapi kode untuk menampilkan menu
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan penjualan ke dalam collection
            Penjualan jual = new Penjualan();
            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Note : ");
            jual.nota = Console.ReadLine();
            Console.Write("Tanggal : ");
            jual.tanggal = Console.ReadLine();
            Console.Write("Customer : ");
            jual.customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            char inputJenis = char.Parse(Console.ReadLine());
            if (inputJenis == 'T')
            {
                jual.jenis = "Tunai";
            }
            else if (inputJenis == 'K')
            {
                jual.jenis = "Kredit";
            }
            else
            {
                Console.Write("Masukkan yang anda Inputkan Salah !");
            }
            Console.Write("Total Nota : ");
            jual.total = float.Parse(Console.ReadLine());

            daftarPenjualan.Add(jual);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menghapus penjualan dari dalam collection
            Console.WriteLine("Hapus Data Pejualan");
            int indeks = -1;
            Console.WriteLine();
            Console.Write("Nota: ");
            string carii = Console.ReadLine();

            for (int i = 0; i < daftarPenjualan.Count; i++)
            {
                if (carii == daftarPenjualan[i].nota)
                {
                    indeks = i;
                } else
                {
                    indeks = -1;
                }
            }

            if(indeks == -1)
            {
                Console.WriteLine("Nota Tidak di temukan");
            } else
            {
                daftarPenjualan.Remove(daftarPenjualan[indeks]);
                Console.WriteLine("Data berhasil di Hapus");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar penjualan yang ada di dalam collection
            Console.WriteLine("Data Penjualan\n");
            int nomor = 1;
            foreach(Penjualan jual in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", nomor, jual.nota, jual.tanggal, jual.customer, jual.jenis, jual.total);
                nomor++;
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
